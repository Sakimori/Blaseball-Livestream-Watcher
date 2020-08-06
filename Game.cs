using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaseball_Livestream
{
    /// <summary>
    /// Serializable class that represents a game update in the gameDataUpdate structure
    /// </summary>
    public class Game
    {
        public List<int> basesOccupied { get; set; }
        public List<string> baseRunners { get; set; }
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
        public int halfInningOuts { get; set; }
        public int homeStrikes { get; set; }
        public int awayStrikes { get; set; }
        public int atBatBalls { get; set; }
        public int atBatStrikes { get; set; }
        public string homePitcher { get; set; }
        public string homePitcherName { get; set; }
        public string awayPitcher { get; set; }
        public string awayPitcherName { get; set; }
        public string homeBatter { get; set; }
        public string homeBatterName { get; set; }
        public string awayBatter { get; set; }
        public string awayBatterName { get; set; }
        public int season { get; set; } = 0;
        public int day { get; set; } = 0;
    }

    public class Inning : IComparable<Inning>
    {
        public Inning() { }
        public Inning(int num) { number = num; }
        public int number { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public int CompareTo(Inning other)
        {
            return number.CompareTo(other.number);
        }

        public void AddRun(int runs, bool topOfInning)
        {
            if (topOfInning) { awayScore += runs; }
            else { homeScore += runs; }
        }
    }
}
