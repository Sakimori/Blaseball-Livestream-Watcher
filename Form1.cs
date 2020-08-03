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
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Permissions;
using System.Diagnostics;
using System.Drawing.Text;
using SocketIOClient;

namespace Blaseball_Livestream
{
    public partial class Form1 : Form
    {
        Client formClient;

        public Form1()
        {
            InitializeComponent();
        }

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
            if (!pastGame.gameComplete) { Debug.WriteLine("Game not over!"); return; } //same as above
            pastGameTable.Visible = true;
            pastGameAway.Text = pastGame.awayTeamNickname;
            pastGameHome.Text = pastGame.homeTeamNickname;
            pastAwayScore.Text = pastGame.awayScore.ToString();
            pastHomeScore.Text = pastGame.homeScore.ToString();
        }

        private void mainButtonR_Click(object sender, EventArgs e)
        {
            pastGameTable.Visible = false;
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
            socket.On("gameDataUpdate", async (data) =>
            {
                serverDataList = JsonConvert.DeserializeObject<List<ServerData>>(data.ToString());
                Debug.WriteLine(serverDataList[0]);
                await socket.DisconnectAsync();
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
        public string id { get; set; }
        public string awayTeamName { get; set; }
        public string awayTeamNickname { get; set; }
        public string awayTeam { get; set; }
        public string homeTeamName { get; set; }
        public string homeTeamNickname { get; set; }
        public string homeTeam { get; set; }
        public List<Inning> innings { get; set; }
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
