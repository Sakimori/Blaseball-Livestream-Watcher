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

namespace Blaseball_Livestream
{
    public partial class Form1 : Form
    {
        Client formClient;

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

        private async void mainButtonLeft_Click(object sender, EventArgs e)
        {
            //taskCompletionSource?.TrySetResult(true);
            liveGameTable.Visible = false;
            Game pastGame = null;
            Team selected = listBox1.SelectedItem as Team;
            List<Game> games = await formClient.GetSingleGamesUpdate();
            foreach(Game game in games)
            {
                if(selected.fullName == game.awayTeamName || selected.fullName == game.homeTeamName)
                {
                    pastGame = game;
                }
            }
            if(pastGame == null) { Debug.WriteLine("Game from that team not found!"); return; } //logs an error and halts routine
            //if (!pastGame.gameComplete) 
            //{ 
            //    Debug.WriteLine("Game not over!");
            //    return; 
            //} //same as above
            pastGameTable.Visible = true;
            pastGameAway.Text = pastGame.awayTeamNickname;
            pastGameHome.Text = pastGame.homeTeamNickname;
            pastAwayScore.Text = pastGame.awayScore.ToString();
            pastHomeScore.Text = pastGame.homeScore.ToString();
        }

        private async void mainButtonR_Click(object sender, EventArgs e)
        {
            //taskCompletionSource?.TrySetResult(true);
            Team selected = listBox1.SelectedItem as Team;
            pastGameTable.Visible = false;
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
            RunGame(liveGame);
        }


        private async void RunGame(Game gameArg)
        {
            Uri uri = new Uri("https://blaseball.com");

            SocketIO socket = new SocketIO(uri);
            Game lastGameState = gameArg;

            socket.On("gameDataUpdate", (data) =>
            {
                List<ServerData> serverDataList = JsonConvert.DeserializeObject<List<ServerData>>(data.ToString());
                foreach(Game game in serverDataList[0].schedule)
                {
                    if(game._id == lastGameState._id && game.lastUpdate != lastGameState.lastUpdate)
                    {
                        UpdateGame(lastGameState, game);
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
        delegate void SetVisCallback(bool vis, Label label);

        private void SetVis(bool vis, Label label)
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

        private void UpdateGame(Game oldState, Game newState)
        {
            int shift = 0;
            if(newState.inning >= 9 && newState.inning != oldState.inning) { SlideInnings(newState.inning); shift = newState.inning - 8; } //changes inning 9 to latest inning



            //Check for hits
            Label hitLabel = null;
            foreach(string hitPhrase in hitPhrases)
            {
                if (newState.lastUpdate.Contains(hitPhrase)) 
                {
                    hitLabel = botH;
                    if (newState.topOfInning) { hitLabel = topH; } 
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
            }
            if (newState.awayScore != oldState.awayScore)
            {
                SetText(newState.awayScore.ToString(), topR);
                //topR.Text = newState.awayScore.ToString();
                Label halfInningLabel = InningToLabel(newState.inning - shift, true);
                SetVis(true, halfInningLabel);
                SetText((Convert.ToInt16(halfInningLabel.Text) + newState.awayScore - oldState.awayScore).ToString(), halfInningLabel);
            }

            //Display zero if inning changeover with no runs
            if(newState.topOfInning != oldState.topOfInning && shift == 0)
            {
                int inning = newState.inning;
                if (newState.topOfInning) { inning -= 1; }
                Label labelCheck = InningToLabel(inning, !newState.topOfInning);
                SetTitle(newState.topOfInning, newState.inning);
                SetVis(true, labelCheck);
            }

            //Change title and add zeros for end of game
            if (newState.gameComplete)
            {
                SetText("Final", liveGameTitle);
                SetVis(true, InningToLabel(9, true));
                SetVis(true, InningToLabel(9, false));
            }
        }

        private void SlideInnings(int extraInnings) //makes space for extra innings
        {
            Label[] labels = { InningToLabel(8, true), InningToLabel(8, false), label9 };
            SetText("0", labels[0]);
            SetText("0", labels[1]);
            SetText(extraInnings.ToString(), labels[2]);
        }

        private Label InningToLabel(int inning, bool topOfInning)
        {
            string front = "bot";
            if (topOfInning) { front = "top"; }
            inning += 1;
            return this.Controls.Find(string.Concat(front, inning.ToString()), true).FirstOrDefault() as Label;
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

    public class Team:IComparable<Team>
    {
        public string _id { get; set; }
        public string fullName { get; set; }
        public string nickname { get; set; }
        public string mainColor { get; set; }
        public string slogan { get; set; }
        public string shorthand { get; set; }
        public int CompareTo(Team other)
        {
            return nickname.CompareTo(other.nickname);
        }
        public override string ToString()
        {
            return String.Concat(new String[3] { fullName, " - ", slogan });
        }
    }

    public class Game
    {
        public string _id { get; set; }
        public string awayTeamName { get; set; }
        public string awayTeamNickname { get; set; }
        public string awayTeam { get; set; }
        public string homeTeamName { get; set; }
        public string homeTeamNickname { get; set; }
        public string homeTeam { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public string lastUpdate { get; set; }
        public bool gameComplete { get; set; }
        public int inning { get; set; }
        public bool topOfInning { get; set; }
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
