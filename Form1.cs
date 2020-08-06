using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Permissions;
using System.Diagnostics;
using System.Drawing.Text;
using SocketIOClient;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Blaseball_Livestream
{
    public partial class Form1 : Form
    {
        Client formClient;

        AutoResetEvent waitHandle = new AutoResetEvent(false);

        List<SaveGame> currentWatchedGames = null;

        bool fileLoaded = false;

        List<SaveGame> loadedFile = null;

        //TaskCompletionSource<bool> taskCompletionSource = null;

        public Form1()
        {
            InitializeComponent();
        }

        String[] hitPhrases = { "Single", "Double", "Triple", "home run" };
        private async void Form1_Load(object sender, EventArgs e)
        {
            formClient = new Client();
            System.Threading.Thread.Sleep(1000);
            List<Team> allTeams = await formClient.GetAllTeams();
            while (allTeams == null) 
            { 
                System.Threading.Thread.Sleep(1000);
                allTeams = await formClient.GetAllTeams();
            }
            allTeams.Sort();
            foreach(Team t in allTeams)
            {
                listBox1.Items.Add(t);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainButtonLeft_Click(object sender, EventArgs e)
        {
            if (fileLoaded && listBox1.SelectedItem != null) { ResetBox(); LoadPastGames(); }
        }

        private async void mainButtonR_Click(object sender, EventArgs e)
        {
            //taskCompletionSource?.TrySetResult(true);
            ResetBox();
            Team selected = listBox1.SelectedItem as Team;
            Game liveGame = null;
            List<Game> games = null;
            while (true)
            {
                try
                {
                    games = await formClient.GetSingleGamesUpdate();
                    break;
                }
                catch
                {
                    Debug.WriteLine("Server error on getting list of games!");
                }
            }
            foreach (Game game in games)
            {
                if (selected.fullName == game.awayTeamName || selected.fullName == game.homeTeamName)
                {
                    liveGame = game;
                }
            }
            if (liveGame == null) { Debug.WriteLine("Game from that team not found!"); return; }
            SaveGame liveSaveGame = new SaveGame();
            RunGame(liveGame, liveSaveGame);
        }


        private async void RunGame(Game gameArg, SaveGame liveSaveGame)
        {
            Uri uri = new Uri("https://blaseball.com");

            SocketIO socket = new SocketIO(uri);
            Game lastGameState = gameArg;
            
            // Under construction; uncomment to try it out
            //GameEventParser parser = new GameEventParser();
            //parser.StartNewGame(gameArg);

            socket.On("gameDataUpdate", (data) =>
            {
                List<ServerData> serverDataList = JsonConvert.DeserializeObject<List<ServerData>>(data.ToString());
                foreach(Game game in serverDataList[0].schedule)
                {
                    if(game._id == lastGameState._id && game.lastUpdate != lastGameState.lastUpdate)
                    {
                        UpdateGame(lastGameState, game, liveSaveGame);
                        // Under construction
                        //var result = parser.ParseGameUpdate(game);
                        //Console.WriteLine(result);
                        lastGameState = game;
                    }
                }
            });

            while (true)
            {
                try
                {
                    await socket.ConnectAsync();
                    break;
                }
                catch
                {
                    Debug.WriteLine("Server error on connecting socket!");
                }
            }


            //Initialize box score with current game state
            liveGameTable.Visible = true;
            string[] titleList = { "Bottom", " of ", (gameArg.inning + 1).ToString() };
            if (gameArg.topOfInning) { titleList[0] = "Top"; }
            liveGameTitle.Text = string.Concat(titleList);
            if (gameArg.gameComplete) 
            { 
                liveGameTitle.Text = "Final";
                SetVis(true, InningToLabel(8, true));
                SetVis(true, InningToLabel(8, false));
            }
            liveGameAwayName.Text = gameArg.awayTeamNickname;
            liveGameHomeName.Text = gameArg.homeTeamNickname;
            int shift = 0;
            if (gameArg.inning >= 9 ) { SlideInnings(gameArg.inning); shift = gameArg.inning - 8; } //makes space for extra innings
            topR.Text = gameArg.awayScore.ToString();
            botR.Text = gameArg.homeScore.ToString();
            Label initScore = InningToLabel(gameArg.inning - shift, true);
            Label initScoreBot = InningToLabel(gameArg.inning - shift, false);
            initScore.Text = gameArg.awayScore.ToString();
            initScore.Visible = true;
            initScoreBot.Text = gameArg.homeScore.ToString();
            if (!gameArg.topOfInning & gameArg.inning == 0) { initScoreBot.Visible = true; }

            //copy info from game in progress to saveable state
            liveSaveGame.awayScore = gameArg.awayScore;
            liveSaveGame.homeScore = gameArg.homeScore;
            liveSaveGame.homeTeamNickname = gameArg.homeTeamNickname;
            liveSaveGame.awayTeamNickname = gameArg.awayTeamNickname;
            liveSaveGame._id = gameArg._id;

            //taskCompletionSource = new TaskCompletionSource<bool>();
            //await taskCompletionSource.Task;
            //await socket.DisconnectAsync();
        }

        //Threadsafe text setting for labels
        delegate void SetTextCallback(string text, Label label);

        private void SetText(string text, Label label)
        {
            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                label.Invoke(d, new object[] { text, label });
            }
            else
            {
                label.Text = text;
            }
        }

        private void SetTitle(bool topOfInning, int inningNum)
        {
            string[] titleList = { "Bottom", " of ", (inningNum + 1).ToString() };
            if (topOfInning) { titleList[0] = "Top"; }
            SetText(string.Concat(titleList), liveGameTitle);
        }


        //Threadsafe visibility setting for labesl
        delegate void SetVisCallback(bool vis, Control label);

        private void SetVis(bool vis, Control label)
        {
            if (label.InvokeRequired)
            {
                SetVisCallback d = new SetVisCallback(SetVis);
                label.Invoke(d, new object[] { vis, label });
            }
            else
            {
                label.Visible = vis;
            }
        }

        private void UpdateGame(Game oldState, Game newState, SaveGame saveGame)
        {
            int shift = 0;
            if(newState.inning >= 9 && newState.inning != oldState.inning) { SlideInnings(newState.inning); shift = newState.inning - 8; } //changes inning 9 to latest inning



            //Check for hits, add to save game counter
            Label hitLabel = null;
            foreach(string hitPhrase in hitPhrases)
            {
                if (newState.lastUpdate.Contains(hitPhrase)) 
                {
                    hitLabel = botH;
                    if (newState.topOfInning) 
                    {
                        saveGame.awayHits += 1;
                        hitLabel = topH; 
                    }
                    else { saveGame.homeHits += 1; }
                }
            }

            if(hitLabel != null)
            {
                SetText((Convert.ToInt16(hitLabel.Text) + 1).ToString(), hitLabel);
            }

            //Check for runs
            if(newState.homeScore != oldState.homeScore)
            {
                SetText(newState.homeScore.ToString(), botR);
                //botR.Text = newState.homeScore.ToString();
                Label halfInningLabel = InningToLabel(newState.inning - shift, false);
                SetVis(true, halfInningLabel);
                //halfInningLabel.Visible = true;
                SetText((Convert.ToInt16(halfInningLabel.Text)+newState.homeScore-oldState.homeScore).ToString(), halfInningLabel);
                saveGame.homeScore = newState.homeScore;
            }
            if (newState.awayScore != oldState.awayScore)
            {
                SetText(newState.awayScore.ToString(), topR);
                //topR.Text = newState.awayScore.ToString();
                Label halfInningLabel = InningToLabel(newState.inning - shift, true);
                SetVis(true, halfInningLabel);
                SetText((Convert.ToInt16(halfInningLabel.Text) + newState.awayScore - oldState.awayScore).ToString(), halfInningLabel);
                saveGame.awayScore = newState.awayScore;
            }

            //Display zero if inning changeover with no runs
            if(newState.topOfInning != oldState.topOfInning)
            {
                int inning = newState.inning;
                if (newState.topOfInning && newState.inning <= 8) { inning -= 1; }
                Label labelCheck = InningToLabel(inning, !newState.topOfInning);
                SetTitle(newState.topOfInning, newState.inning);
                SetVis(true, labelCheck);
            }

            //Change title and add zeros for end of game
            if (newState.gameComplete)
            {
                SetText("Final", liveGameTitle);
                SetVis(true, InningToLabel(8, true));
                SetVis(true, InningToLabel(8, false));

                //Run game save routine
                SaveGameToFile(saveGame);
            }
        }

        private void SlideInnings(int extraInnings) //makes space for extra innings
        {
            Label[] labels = { InningToLabel(8, true), InningToLabel(8, false), label9 };
            SetText("0", labels[0]);
            SetText("0", labels[1]);
            SetText((extraInnings+1).ToString(), labels[2]);
        }

        private Label InningToLabel(int inning, bool topOfInning)
        {
            string front = "bot";
            if (topOfInning) { front = "top"; }
            inning += 1;
            if(inning >= 10) { inning = 9; }
            return this.Controls.Find(string.Concat(front, inning.ToString()), true).FirstOrDefault() as Label;
        }

        private void SaveGameToFile(SaveGame saveGame)
        {

        }

        private void UpdateWatchedGame(List<SaveGame> games, Game gameUpdate)
        {
            SaveGame thisGame = null;
            SaveGame newGame = new SaveGame();
            foreach (SaveGame game in games)
            {
                if(game._id == gameUpdate._id)
                {
                    thisGame = game;
                }
            }

            if(thisGame == null) //if game not found, initialize with same ID
            {
                newGame._id = gameUpdate._id;
                newGame.inningsList = new List<Inning>();
                newGame.inningsList.Add(new Inning());
                newGame.inningsList[0].number = gameUpdate.inning + 1;
                newGame.topOfInning = true;
                newGame.homeTeamNickname = gameUpdate.homeTeamNickname;
                newGame.awayTeamNickname = gameUpdate.awayTeamNickname;
                games.Add(newGame);
                thisGame = newGame;
            }

            if(thisGame.lastUpdate == gameUpdate.lastUpdate) { return; } //Leave, nothing to do

            Inning thisInning;
            thisGame.inningsList.Sort();
            thisInning = thisGame.inningsList.Last();

            if (thisGame.topOfInning != gameUpdate.topOfInning)
            {
                if (gameUpdate.topOfInning)
                {
                    thisInning = new Inning();
                    thisInning.number = gameUpdate.inning + 1;

                    thisGame.inningsList.Add(thisInning);
                }
            }

            //check for hits, add to game total
            foreach(string hitPhrase in hitPhrases)
            {
                if (gameUpdate.lastUpdate.Contains(hitPhrase))
                {
                    if (gameUpdate.topOfInning) { thisGame.awayHits += 1; }
                    else thisGame.homeHits += 1;
                }
            }

            //check for runs, add to game and inning total
            int homeScoreDiff = gameUpdate.homeScore - thisGame.homeScore;
            int awayScoreDiff = gameUpdate.awayScore - thisGame.awayScore;
            if (homeScoreDiff > 0)
            {
                thisGame.homeScore = gameUpdate.homeScore;
                thisInning.homeScore += homeScoreDiff;
            }
            else if (awayScoreDiff > 0)
            {
                thisGame.awayScore = gameUpdate.awayScore;
                thisInning.awayScore += awayScoreDiff;
            }

            thisGame.topOfInning = gameUpdate.topOfInning;
            thisGame.lastUpdate = gameUpdate.lastUpdate;
        }
        private async void SaveAllGamesToFile(SaveFileDialog fileDialog)
        {
            Uri uri = new Uri("https://blaseball.com");

            SocketIO socket = new SocketIO(uri);

            bool roundStarted = false;
            bool allCompleted = false;
            currentWatchedGames = new List<SaveGame>();

            socket.On("gameDataUpdate", (data) =>
            {
                List<ServerData> serverDataList = JsonConvert.DeserializeObject<List<ServerData>>(data.ToString());
                List<Game> games = serverDataList[0].schedule;

                bool activeGame = !roundStarted;
                bool indicatorFlipped = false;
                foreach (Game game in serverDataList[0].schedule)
                {                   
                    if (!game.gameComplete && !roundStarted) { roundStarted = true; } //mark round as started, start watching for all games completed
                    if (roundStarted && !activeGame) { activeGame = !game.gameComplete; } //if round has started and no active game found yet, set flag if this game is active
                    if(!game.gameComplete) //if this game is currently active
                    {
                        UpdateWatchedGame(currentWatchedGames, game);
                    }
                }
                allCompleted = !activeGame;
                if(!indicatorFlipped && roundStarted) { SetText("Recording...", recordIndicator); indicatorFlipped = true; }
                if (allCompleted) 
                { 
                    foreach(SaveGame saveGame in currentWatchedGames)
                    {
                        saveGame.lastUpdate = "Game over.";
                        saveGame.gameComplete = true;
                    }
                    waitHandle.Set(); 
                }


            });

            await socket.ConnectAsync();

            waitHandle.WaitOne();

            

            JsonSerializer serializer = new JsonSerializer(); 

            using (Stream fileStreamBytes =
                fileDialog.OpenFile())
            {
                using (StreamWriter fileStream =
                    new StreamWriter(fileStreamBytes))
                {
                    serializer.Serialize(fileStream, currentWatchedGames);
                }
            }
            SetVis(false, recordIndicator);
            MessageBox.Show("All games completed!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(StartWatching);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void StartWatching()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Save New File";
            fileDialog.DefaultExt = "json";
            fileDialog.OverwritePrompt = true;
            fileDialog.AddExtension = true;
            fileDialog.ShowDialog();

            SetVis(true, recordIndicator);
            SetText("Waiting to record...", recordIndicator);

            SaveAllGamesToFile(fileDialog);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileLoaded = false;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Recorded Games File";
            fileDialog.CheckFileExists = true;
            fileDialog.ShowDialog();
            bool loadedNow = false;

            try
            {
                using (StreamReader file = File.OpenText(fileDialog.FileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    loadedFile = (List<SaveGame>)serializer.Deserialize(file, typeof(List<SaveGame>));
                    loadedNow = true;
                }
            }
            catch
            {
                MessageBox.Show("File could not be loaded!");
                return;
            }

            if (!loadedNow)
            {
                MessageBox.Show("File could not be loaded!");
                return;
            }

            SetVis(true, loadedIndicator);
            fileLoaded = true;
        }

        private void ResetBox()
        {
            IEnumerable<int> inningNums = Enumerable.Range(0, 9);
            foreach (int num in inningNums)
            {
                Label top = InningToLabel(num, true);
                Label bot = InningToLabel(num, false);
                SetVis(false, top);
                SetVis(false, bot);
                SetText("0", top);
                SetText("0", bot);
            }

            SetText("0", topR);
            SetText("0", botR);
            SetText("0", topH);
            SetText("0", botH);
        }

        private void LoadPastGames()
        {
            if (!fileLoaded) { MessageBox.Show("No file loaded!"); return; }

            SaveGame thisGame = null;
            Team selectedTeam = listBox1.SelectedItem as Team;
            foreach (SaveGame game in loadedFile)
            {
                if (selectedTeam.nickname == game.awayTeamNickname || selectedTeam.nickname == game.homeTeamNickname)
                {
                    thisGame = game;
                }
            }

            if (thisGame == null) { MessageBox.Show("Team not found in file!"); return; } //notify and leave if no game found

            //set team names
            SetVis(true, liveGameTable);
            SetText(thisGame.awayTeamNickname, liveGameAwayName);
            SetText(thisGame.homeTeamNickname, liveGameHomeName);
            SetText(thisGame.awayScore.ToString(), topR);
            SetText(thisGame.homeScore.ToString(), botR);
            SetText("Past Game", liveGameTitle);

            thisGame.inningsList.Sort();
            if(thisGame.inningsList.Last().number > 8) //handle final inning, in case of extra innings
            {
                SetText(thisGame.inningsList.Last().awayScore.ToString(), top9);
                SetText(thisGame.inningsList.Last().homeScore.ToString(), bot9);
                SetText(thisGame.inningsList.Last().number.ToString(), label9);
                SetVis(true, top9);
                SetVis(true, bot9);
            }

            foreach (Inning inning in thisGame.inningsList) //handle rest of innings as normal
            {
                if (inning.number <= 8)
                {


                    Label topLabel = InningToLabel(inning.number - 1, true);
                    Label botLabel = InningToLabel(inning.number - 1, false);
                    SetVis(true, topLabel);
                    SetVis(true, botLabel);

                    Debug.WriteLine(string.Concat(topLabel.Name, " ", inning.awayScore.ToString()));
                    SetText(inning.awayScore.ToString(), topLabel);
                    SetText(inning.homeScore.ToString(), botLabel);
                }
            }

            //load hit numbers
            SetText(thisGame.awayHits.ToString(), topH);
            SetText(thisGame.homeHits.ToString(), botH);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(top7.Text);
        }
    }
    class Client
    {
        static HttpClient webClient = new HttpClient();

        static Uri uri = new Uri("https://blaseball.com");

        static SocketIO socket = new SocketIO(uri);

        public async Task<Team> GetTeamFromName(string searchName) //returns a Team object from a short or long team name string
        {
            HttpResponseMessage response = await webClient.GetAsync("https://blaseball.com/database/allTeams");
            //Debug.WriteLine(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                List<Team> allTeams = JsonConvert.DeserializeObject<List<Team>>(responseString);
                //Debug.WriteLine(allTeams);
                foreach(Team t in allTeams)
                {
                    //Debug.WriteLine(t.fullName);
                    //Debug.WriteLine(t.nickname);
                    if(t.nickname == searchName || t.fullName == searchName)
                    {
                        return t;
                    }
                }
            }
            return null;
        }

        public async Task<List<Team>> GetAllTeams() //returns a list of all teams
        {
            HttpResponseMessage response = await webClient.GetAsync("https://blaseball.com/database/allTeams");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Team>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<Game>> GetSingleGamesUpdate() //returns a single list of Games
        {
            List<ServerData> serverDataList = null;
            socket.On("gameDataUpdate", (data) =>
            {
                serverDataList = JsonConvert.DeserializeObject<List<ServerData>>(data.ToString());
            });
            
            await socket.ConnectAsync();
            while(serverDataList == null) { System.Threading.Thread.Sleep(100); }
            return serverDataList[0].schedule;
        }
    }



    public class SaveGame : Game
    {
        public List<Inning> inningsList { get; set; }
        public int homeHits { get; set; }
        public int awayHits { get; set; }
    }

    public class ServerData
    {
        public List<Game> schedule { get; set; }
    }
    public class Inning:IComparable<Inning>
    {
        public int number { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public int CompareTo(Inning other)
        {
            return number.CompareTo(other.number);
        }
    }

}
