using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaseball_Livestream
{
    class SaveGame
    {
        //Default constructor
        public SaveGame() { }

        //Constructor with only id
        public SaveGame(string idArg)
        {
            _id = idArg;
        }

        //Constructor with GameEvent. Initializes score.
        public SaveGame(GameEvent gameEvent)
        {
            awayScore = (int)gameEvent.awayScore;
            homeScore = (int)gameEvent.homeScore;

            if (gameEvent.topOfInning)
            {
                awayPlayers.Add(new Batter(gameEvent.batterId));
                homePlayers.Add(new Pitcher(gameEvent.pitcherId));
            }

            else
            {
                awayPlayers.Add(new Pitcher(gameEvent.pitcherId));
                homePlayers.Add(new Batter(gameEvent.batterId));
            }

        }

        //Constructor with GameEvent. Includes naming teams.
        public SaveGame(GameEvent gameEvent, string updateAwayTeamNickname, string updateHomeTeamNickname)
        {
            _id = gameEvent.gameId;
            awayTeamNickname = updateAwayTeamNickname;
            homeTeamNickname = updateHomeTeamNickname;

            awayScore = (int)gameEvent.awayScore;
            homeScore = (int)gameEvent.homeScore;
            
            if (gameEvent.topOfInning)
            {
                awayPlayers.Add(new Batter(gameEvent.batterId));
                homePlayers.Add(new Pitcher(gameEvent.pitcherId));
            }

            else
            {
                awayPlayers.Add(new Pitcher(gameEvent.pitcherId));
                homePlayers.Add(new Batter(gameEvent.batterId));
            }
        }

        //Constructor with entire game update
        public SaveGame(Game game)
        {
            _id = game._id;
            awayTeamNickname = game.awayTeamNickname;
            homeTeamNickname = game.homeTeamNickname;
            awayTeamID = game.awayTeam;
            homeTeamID = game.homeTeam;

            awayScore = game.awayScore;
            homeScore = game.homeScore;

            season = game.season;
            day = game.day;
        }

        public String[] hitStrings = { "Single", "Double", "Triple", "home run", "grand slam" };


        public string _id { get; set; }
        public List<Inning> inningsList { get; set; }
        public string awayTeamNickname { get; set; }
        public string awayTeamID { get; set; }
        public string homeTeamNickname { get; set; }
        public string homeTeamID { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public int homeHits { get; set; }
        public int awayHits { get; set; }
        public string lastUpdate { get; set; }
        public bool gameComplete { get; set; }
        public bool topOfInning { get; set; }
        public List<Player> awayPlayers { get; set; }
        public List<Player> homePlayers { get; set; }
        public List<int> basesOccupied;
        public int homeRISP { get; set; }
        public int awayRISP { get; set; }
        public int homeRunsOn2Out { get; set; }
        public int awayRunsOn2Out { get; set; }
        public int homeHitsOn2Out { get; set; }
        public int awayHitsOn2Out { get; set; }
        public int awaySteals { get; set; }
        public int awayCaughtStealing { get; set; }
        public int homeSteals { get; set; }
        public int homeCaughtStealing { get; set; }
        public int season { get; set; } = 0;
        public int day { get; set; } = 0;

        public override string ToString()
        {
            return string.Concat(awayTeamNickname, " @ ", homeTeamNickname, ", Season ", season.ToString(), " Day ", day.ToString());
        }

        //Update a savegame with a game event
        public void UpdateSaveGame(GameEvent gameEvent)
        {

        }


        //Update a savegame with a full new game state
        public void UpdateSaveGame(Game newState)
        {
            if (lastUpdate == newState.lastUpdate) { return; } //check for unnecessary updates

            lastUpdate = newState.lastUpdate;

            //bookkeeping on day, in case it was init'd with GameEvent
            if(season == 0) { season = newState.season; }
            if(day == 0) { day = newState.day; }

            Inning thisInning = null;
            
            //find inning we need, init new one if required
            foreach(Inning inning in inningsList)
            {
                if(inning.number == (newState.inning + 1))
                {
                    thisInning = inning;
                }
            }
            if (thisInning == null)
            {
                thisInning = new Inning();
                thisInning.number = (newState.inning + 1);
                inningsList.Add(thisInning);
            }


            //find batter and pitcher in respective team lists
            Batter batter = null;
            Pitcher pitcher = null;
            if (topOfInning) 
            {
                bool found = false;
                foreach(Player player in awayPlayers)
                {
                    if(player._id == newState.awayBatter)
                    {
                        batter = player as Batter;
                        found = true;
                    }
                }
                if (!found)
                {
                    batter = new Batter(newState.awayBatter);
                    batter.name = newState.awayBatterName;
                    awayPlayers.Add(batter);
                }

                found = false;

                foreach (Player player in homePlayers)
                {
                    if (player._id == newState.homePitcher)
                    {
                        pitcher = player as Pitcher;
                        found = true;
                    }
                }
                if (!found)
                {
                    pitcher = new Pitcher(newState.homePitcher);
                    pitcher.name = newState.homePitcherName;
                    homePlayers.Add(pitcher);
                }
            }
            else
            {
                bool found = false;
                foreach (Player player in homePlayers)
                {
                    if (player._id == newState.homeBatter)
                    {
                        batter = player as Batter;
                        found = true;
                    }
                }
                if (!found)
                {
                    batter = new Batter(newState.homeBatter);
                    batter.name = newState.homeBatterName;
                    homePlayers.Add(batter);
                }

                found = false;

                foreach (Player player in awayPlayers)
                {
                    if (player._id == newState.awayPitcher)
                    {
                        pitcher = player as Pitcher;
                        found = true;
                    }
                }
                if (!found)
                {
                    pitcher = new Pitcher(newState.awayPitcher);
                    pitcher.name = newState.awayPitcherName;
                    awayPlayers.Add(pitcher);
                }
            }

            //get any runs scored on play
            int scoredHome = newState.homeScore - homeScore;
            int scoredAway = newState.awayScore - awayScore;
            int scored = scoredAway + scoredHome;
            //and update runs
            homeScore = newState.homeScore;
            awayScore = newState.awayScore;


            //check for hits
            foreach (string hitString in hitStrings)
            {
                if (lastUpdate.Contains(hitString))
                {
                    batter.AddHit(scored);
                    
                    if (newState.halfInningOuts == 2)
                    {
                        if (topOfInning) { awayHitsOn2Out += 1; awayRunsOn2Out += scored; }
                        else { homeHitsOn2Out += 1; homeRunsOn2Out += scored; }
                    }
                }
                if (hitString == "home run" || hitString == "grand slam") { batter.homeRuns += 1; }

                

                pitcher.pitchCount += 1;
            }

            //check for out types
            bool gotOut = false;
            if (lastUpdate.Contains("sacrifice")) { batter.AddOut(OutTypes.Sacrifice); batter.rbis += scored; gotOut = true; }
            else if (lastUpdate.Contains("fielder's choice")) { batter.AddOut(OutTypes.FieldersChoice); gotOut = true; }
            else if (lastUpdate.Contains("strikes out") || lastUpdate.Contains("struck out")) { batter.AddOut(OutTypes.Strikeout); gotOut = true; }
            else if (lastUpdate.Contains("ground out")) { batter.AddOut(OutTypes.Groundout); gotOut = true; }
            else if (lastUpdate.Contains("flyout")) { batter.AddOut(OutTypes.Flyout); gotOut = true; }
            else if (lastUpdate.Contains("double play")) { batter.AddOut(OutTypes.DoublePlay); gotOut = true; pitcher.outsRecorded += 1; }
            //add the out to pitcher stats
            if (gotOut) { pitcher.AddOut(); }

            //check for walks
            if(lastUpdate.Contains("draws a walk"))
            {
                batter.walks += 1;
                pitcher.walks += 1;
                pitcher.pitchCount += 1;
            }

            //pitch with no interesting result
            if(lastUpdate.Contains("Ball.") || lastUpdate.Contains("Strike,") || lastUpdate.Contains("Foul Ball.")) { pitcher.pitchCount += 1; }

            //steal attempt
            if(lastUpdate.Contains("caught stealing"))
            {
                if (topOfInning) { awayCaughtStealing += 1; }
                else { homeCaughtStealing += 1; }
            }
            else if (lastUpdate.Contains("steals"))
            {
                if (topOfInning) { awaySteals += 1; }
                else { homeSteals += 1; }
            }

            //check for turnover
            if(topOfInning != newState.topOfInning)
            {
                foreach(int runnerNum in basesOccupied)
                {
                    if(runnerNum == 1 || runnerNum == 2)
                    {
                        if (topOfInning) { awayRISP += 1; }
                        else { homeRISP += 1; }
                    }
                }
            }
            topOfInning = newState.topOfInning;


        }
    }




}
