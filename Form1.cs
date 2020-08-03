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
using SocketIOClient;
using Quobject.EngineIoClientDotNet.Client;
using System.Drawing.Text;

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
            while (allTeams == null) { System.Threading.Thread.Sleep(3000); }
            allTeams.Sort();
            foreach(Team t in allTeams)
            {
                listBox1.Items.Add(t);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            Team selected = listBox1.SelectedItem as Team;
        }
    }
    class Client
    {
        static HttpClient webClient = new HttpClient();

        public async void OpenSocket()
        {

        }

        public async Task<Team> GetTeamFromName(string searchName)
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

        public async Task<List<Team>> GetAllTeams()
        {
            HttpResponseMessage response = await webClient.GetAsync("https://blaseball.com/database/allTeams");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Team>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
    }

    public class Team:IComparable<Team>
    {
        public string _id { get; set; }
        public string fullName { get; set; }
        public string nickname { get; set; }
        public string mainColor { get; set; }
        public int CompareTo(Team other)
        {
            return nickname.CompareTo(other.nickname);
        }
        public override string ToString()
        {
            return nickname;
        }
    }

    public class Game
    {
        public string id { get; set; }
        public Team awayTeam { get; set; }
        public Team homeTeam { get; set; }
        public List<Inning> innings { get; set; }
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
