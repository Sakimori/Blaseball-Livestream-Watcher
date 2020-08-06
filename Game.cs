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
        public string awayPitcher { get; set; }
        public string homeBatter { get; set; }
        public string awayBatter { get; set; }
    }
}
