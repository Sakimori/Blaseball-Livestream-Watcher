using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaseball_Livestream
{
    public class SaveGame : IComparable<SaveGame>
    {
        //Default constructor
        public SaveGame() 
        {
            inningsList = new List<Inning>();
            awayPitchers = new Dictionary<string, Pitcher>();
            homePitchers = new Dictionary<string, Pitcher>();
            awayBatters = new Dictionary<string, Batter>();
            homeBatters = new Dictionary<string, Batter>();
            basesOccupied = new List<int>();
            baseRunners = new List<string>();
        }

        //Constructor with only id
        public SaveGame(string idArg)
        {
            _id = idArg;

            inningsList = new List<Inning>();
            awayPitchers = new Dictionary<string, Pitcher>();
            homePitchers = new Dictionary<string, Pitcher>();
            awayBatters = new Dictionary<string, Batter>();
            homeBatters = new Dictionary<string, Batter>();
            basesOccupied = new List<int>();
            baseRunners = new List<string>();
        }

        //Constructor with GameEvent. Initializes score.
        public SaveGame(GameEvent gameEvent)
        {
            awayScore = (int)gameEvent.awayScore;
            homeScore = (int)gameEvent.homeScore;

            awayPitchers = new Dictionary<string, Pitcher>();
            homePitchers = new Dictionary<string, Pitcher>();
            awayBatters = new Dictionary<string, Batter>();
            homeBatters = new Dictionary<string, Batter>();
            baseRunners = new List<string>(); 

            if (gameEvent.topOfInning)
            {
                awayBatters.Add(gameEvent.batterId, new Batter(gameEvent.batterId));
                homePitchers.Add(gameEvent.pitcherId, new Pitcher(gameEvent.pitcherId));
            }

            else
            {
                awayPitchers.Add(gameEvent.pitcherId, new Pitcher(gameEvent.pitcherId));
                homeBatters.Add(gameEvent.batterId, new Batter(gameEvent.batterId));
            }

            lastPitcher = new Pitcher();
            lastBatter = new Batter();

            inningsList = new List<Inning>();
            basesOccupied = new List<int>();
        }

        //Constructor with GameEvent. Includes naming teams.
        public SaveGame(GameEvent gameEvent, string updateAwayTeamNickname, string updateHomeTeamNickname)
        {
            _id = gameEvent.gameId;
            awayTeamNickname = updateAwayTeamNickname;
            homeTeamNickname = updateHomeTeamNickname;

            awayScore = (int)gameEvent.awayScore;
            homeScore = (int)gameEvent.homeScore;

            awayPitchers = new Dictionary<string, Pitcher>();
            homePitchers = new Dictionary<string, Pitcher>();
            awayBatters = new Dictionary<string, Batter>();
            homeBatters = new Dictionary<string, Batter>();
            baseRunners = new List<string>();

            if (gameEvent.topOfInning)
            {
                awayBatters.Add(gameEvent.batterId, new Batter(gameEvent.batterId));
                homePitchers.Add(gameEvent.pitcherId, new Pitcher(gameEvent.pitcherId));
            }

            else
            {
                awayPitchers.Add(gameEvent.pitcherId, new Pitcher(gameEvent.pitcherId));
                homeBatters.Add(gameEvent.batterId, new Batter(gameEvent.batterId));
            }

            lastPitcher = new Pitcher();
            lastBatter = new Batter();

            inningsList = new List<Inning>();
            basesOccupied = new List<int>();
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

            inningsList = new List<Inning>();
            awayPitchers = new Dictionary<string, Pitcher>();
            homePitchers = new Dictionary<string, Pitcher>();
            awayBatters = new Dictionary<string, Batter>();
            homeBatters = new Dictionary<string, Batter>();
            basesOccupied = new List<int>();
            baseRunners = new List<string>();
            if (game.awayBatter != "" && game.homeBatter != "")
            { 
                if (game.topOfInning && game.awayBatter != "" && game.homeBatter != "")
                {
                    lastBatter = new Batter(game.awayBatter);
                    lastBatter.name = game.awayBatterName;
                    awayBatters.Add(lastBatter._id, lastBatter);

                    lastPitcher = new Pitcher(game.homePitcher);
                    lastPitcher.name = game.homePitcherName;
                    homePitchers.Add(lastPitcher._id, lastPitcher);
                }
                else
                {
                    lastBatter = new Batter(game.homeBatter);
                    lastBatter.name = game.homeBatterName;
                    homeBatters.Add(lastBatter._id, lastBatter);

                    lastPitcher = new Pitcher(game.awayPitcher);
                    lastPitcher.name = game.awayPitcherName;
                    awayPitchers.Add(lastPitcher._id, lastPitcher);
                }
            }
            awayBatting = true;
        }

        


        public string _id { get; set; }
        public List<Inning> inningsList { get; set; }
        [JsonIgnore]
        public int lastInning { get; set; }
        [JsonIgnore]
        public List<string> baseRunners;
        public string awayTeamNickname { get; set; }
        public string awayTeamID { get; set; }
        public string homeTeamNickname { get; set; }
        public string homeTeamID { get; set; }
        public int awayScore { get; set; }
        public int homeScore { get; set; }
        public int homeHits { get; set; }
        public int awayHits { get; set; }
        [JsonIgnore]
        public string lastUpdate { get; set; }
        [JsonIgnore]
        public string thisUpdate { get; set; }
        public bool gameComplete { get; set; }
        [JsonIgnore]
        public bool topOfInning { get; set; }
        [JsonIgnore]
        public bool lastTopOfInning { get; set; }
        [JsonIgnore]
        public bool turnover { get; set; }
        [JsonIgnore]
        public bool awayBatting { get; set; }
        public Dictionary<string,Batter> awayBatters { get; set; }
        public Dictionary<string, Batter> homeBatters { get; set; }
        public Dictionary<string,Pitcher> awayPitchers { get; set; }
        public Dictionary<string, Pitcher> homePitchers { get; set; }
        [JsonIgnore]
        public List<int> basesOccupied { get; set; }
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
        [JsonIgnore]
        public Pitcher lastPitcher { get; set; } = new Pitcher("");
        [JsonIgnore]
        public Batter lastBatter { get; set; } = new Batter("");

        public override string ToString()
        {
            return string.Concat(awayTeamNickname, " @ ", homeTeamNickname, ", Season ", (season+1).ToString(), " Day ", (day+1).ToString());
        }

        //Update a savegame with a game event
        public void UpdateSaveGame(GameEvent gameEvent)
        {

        }

        //public void DisplaySaveGame()
        //{
        //    string output = string.Concat("")


        //    MessageBox.Show();
        //}

        //Update a savegame with a full new game state
        public void UpdateSaveGame(Game newState)
        {
            String[] hitStrings = { "Single", "Double", "Triple", "home run", "grand slam" };

            if (thisUpdate == newState.lastUpdate) { return; } //check for unnecessary updates

            thisUpdate = newState.lastUpdate;

            if (thisUpdate.Contains("Bottom of") || thisUpdate.Contains("Top of")) //nothing interesting happens here except putting players on the wrong team
            {
                return;
            }



            //bookkeeping on day, in case it was init'd with GameEvent
            if (season == 0) { season = newState.season; }
            if(day == 0) { day = newState.day; }

            if(lastTopOfInning == newState.topOfInning && lastTopOfInning)
            {
                awayBatting = true;
            }
            else if(lastTopOfInning == newState.topOfInning && !lastTopOfInning)
            {
                awayBatting = false;
            }

            //check for turnover
            if (lastTopOfInning != newState.topOfInning)
            {
                foreach (int runnerNum in basesOccupied)
                {
                    if (runnerNum == 1 || runnerNum == 2)
                    {
                        if (awayBatting) { awayRISP += 1; }
                        else { homeRISP += 1; }
                    }
                }
                turnover = true;
            }
            else { turnover = false; }

            Inning thisInning = null;

            //find inning we need, init new one if required
            try
            {
                foreach (Inning inning in inningsList)
                {
                    if (inning.number == (newState.inning + 1))
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
            }
            catch
            {
                thisInning = new Inning(newState.inning + 1);
                inningsList.Add(thisInning);
            }


            //find batter and pitcher in respective team lists
            Batter batter = null;
            Pitcher pitcher = null;

            if (awayBatting) 
            {
                bool foundAB = awayBatters.TryGetValue(lastBatter._id, out batter);
                if (!foundAB && lastBatter._id != "") 
                {
                    batter = new Batter(lastBatter._id);
                    batter.name = lastBatter.name;
                    awayBatters[batter._id] = batter;
                }

                bool foundHP = homePitchers.TryGetValue(lastPitcher._id, out pitcher);
                if (!foundHP && lastPitcher._id != "")
                {
                    pitcher = new Pitcher(lastPitcher._id);
                    pitcher.name = lastPitcher.name;
                    homePitchers[pitcher._id] = pitcher;
                }

                lastBatter = new Batter(newState.awayBatter);
                lastBatter.name = newState.awayBatterName;

                lastPitcher = new Pitcher(newState.homePitcher);
                lastPitcher.name = newState.homePitcherName;
            }
            else
            {
                bool foundHB = homeBatters.TryGetValue(lastBatter._id, out batter);
                if (!foundHB && lastBatter._id != "")
                {
                    batter = new Batter(lastBatter._id);
                    batter.name = lastBatter.name;
                    homeBatters[batter._id] = batter;
                }

                bool foundHP = awayPitchers.TryGetValue(lastPitcher._id, out pitcher);
                if (!foundHP && lastPitcher._id != "")
                {
                    pitcher = new Pitcher(lastPitcher._id);
                    pitcher.name = lastPitcher.name;
                    awayPitchers[pitcher._id] = pitcher;
                }

                lastBatter = new Batter(newState.homeBatter);
                lastBatter.name = newState.homeBatterName;

                lastPitcher = new Pitcher(newState.awayPitcher);
                lastPitcher.name = newState.awayPitcherName;
            }
            
            if (thisUpdate.Contains("batting for")) { return; } //not a play of record, needed to get this far to set lastBatter
            else if (batter == null || pitcher == null) { return; } //last play didn't have a batter or pitcher or both
            


            //get any runs scored on play
            int scoredHome = newState.homeScore - homeScore;
            int scoredAway = newState.awayScore - awayScore;
            int scored = scoredAway + scoredHome;
            //and update runs
            homeScore = newState.homeScore;
            awayScore = newState.awayScore;
            thisInning.AddRun(scoredAway, true);
            thisInning.AddRun(scoredHome, false);

            pitcher.runs += scored; //they deserve it


            //check for hits
            foreach (string hitString in hitStrings)
            {
                if (thisUpdate.Contains(hitString))
                {
                    batter.AddHit(scored);

                    if (newState.halfInningOuts == 2)
                    {
                        if (lastTopOfInning) { awayHitsOn2Out += 1; awayRunsOn2Out += scored; }
                        else { homeHitsOn2Out += 1; homeRunsOn2Out += scored; }
                    }

                    pitcher.pitchCount += 1;
                    pitcher.hits += 1;
                    if (hitString == "Double") { batter.doubles += 1; }
                    else if (hitString == "Triple") { batter.triples += 1; }
                    else if (hitString == "home run" || hitString == "grand slam") { batter.homeRuns += 1; pitcher.homeRuns += 1; }

                    if (lastTopOfInning) { awayHits += 1; }
                    else { homeHits += 1; }
                }       
            }

            //check for out types
            bool gotOut = false;
            if (thisUpdate.Contains("sacrifice")) { batter.AddOut(OutTypes.Sacrifice); batter.rbis += scored; gotOut = true; }
            else if (thisUpdate.Contains("fielder's choice")) { batter.AddOut(OutTypes.FieldersChoice); gotOut = true; }
            else if (thisUpdate.Contains("strikes out") || thisUpdate.Contains("struck out")) 
            { 
                batter.AddOut(OutTypes.Strikeout); gotOut = true;
                pitcher.strikeouts += 1;
            }
            else if (thisUpdate.Contains("ground out")) { batter.AddOut(OutTypes.Groundout); gotOut = true; }
            else if (thisUpdate.Contains("flyout")) { batter.AddOut(OutTypes.Flyout); gotOut = true; }
            else if (thisUpdate.Contains("double play")) { batter.AddOut(OutTypes.DoublePlay); gotOut = true; pitcher.outsRecorded += 1; }
            //add the out to pitcher stats
            if (gotOut) { pitcher.AddOut(); }

            //check for walks
            if(thisUpdate.Contains("draws a walk"))
            {
                batter.walks += 1;
                batter.plateAppearances += 1;
                pitcher.walks += 1;
                pitcher.pitchCount += 1;
            }

            //pitch with no interesting result
            if(thisUpdate.Contains("Ball.") || thisUpdate.Contains("Strike,") || thisUpdate.Contains("Foul Ball.")) { pitcher.pitchCount += 1; }

            baseRunners = newState.baseRunners;
            

            //steal attempt
            if(thisUpdate.Contains("caught stealing"))
            {
                if (awayBatting) { awayCaughtStealing += 1; }
                else { homeCaughtStealing += 1; }
            }
            else if (thisUpdate.Contains("steals"))
            {
                if (awayBatting) { awaySteals += 1; }
                else { homeSteals += 1; }
            }


            lastTopOfInning = newState.topOfInning;
            basesOccupied = newState.basesOccupied;
        }

        public int CompareTo(SaveGame other)
        {
            return (day + (season * 1000)).CompareTo(other.day + (other.season * 1000)); //sorts by S0DD in case a season goes over 99 games for any reason
        }

        public void CleanSave() //Remove ghost players from wrong team
        {
            Dictionary<string, List<string>> toRemove = new Dictionary<string, List<string>>();
            toRemove.Add("awayB", new List<string>());
            toRemove.Add("homeB", new List<string>());
            toRemove.Add("awayP", new List<string>());
            toRemove.Add("homeP", new List<string>());

            foreach (Batter batter in awayBatters.Values)
            {
                if(batter.plateAppearances == 0) { toRemove["awayB"].Add(batter._id); } 
            }
            foreach (Batter batter in homeBatters.Values)
            {
                if (batter.plateAppearances == 0) { toRemove["homeB"].Add(batter._id); }
            }
            foreach (Pitcher pitcher in awayPitchers.Values)
            {
                if (pitcher.pitchCount == 0) { toRemove["awayP"].Add(pitcher._id); }
            }
            foreach (Pitcher pitcher in homePitchers.Values)
            {
                if (pitcher.pitchCount == 0) { toRemove["homeP"].Add(pitcher._id); }
            }

            foreach(string zero in toRemove["awayB"])
            {
                awayBatters.Remove(zero);
            }
            foreach (string zero in toRemove["homeB"])
            {
                homeBatters.Remove(zero);
            }
            foreach (string zero in toRemove["awayP"])
            {
                awayPitchers.Remove(zero);
            }
            foreach (string zero in toRemove["homeP"])
            {
                homePitchers.Remove(zero);
            }
        }
    }




}
