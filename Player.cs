using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaseball_Livestream
{
    public class Player
    {
        public Player() { }

        public string _id { get; set; } = null;
        public string name { get; set; } = null;
        public bool deceased { get; set; }
        public int hits { get; set; }
        public int homeRuns { get; set; }
        public int walks { get; set; }
    }

    public class Batter : Player
    {
        public Batter() { }
        public Batter(string id)
        {
            _id = id;
        }
        public int plateAppearances { get; set; }
        public int atBats { get; set; }
        public int rbis { get; set; }
        public Dictionary<OutTypes, int> outsTaken { get; set; } = new Dictionary<OutTypes, int>()
        {
            {OutTypes.Flyout, 0},
            {OutTypes.Groundout, 0},
            {OutTypes.Sacrifice, 0},
            {OutTypes.Strikeout, 0},
            {OutTypes.DoublePlay, 0},
            {OutTypes.CaughtStealing, 0},
            {OutTypes.FieldersChoice, 0}
        };
        public int doubles { get; set; }
        public int triples { get; set; }

        //Adding outs will automatically track atbats and plate appearances
        public void AddOut(OutTypes outType)
        {
            if (!outsTaken.ContainsKey(outType)) { outsTaken.Add(outType, 0); }

            outsTaken[outType] += 1;
            if(outType != OutTypes.CaughtStealing)
            {
                plateAppearances += 1;
                if(outType != OutTypes.Sacrifice) { atBats += 1; }
            }
        }

        public void AddHit()
        {
            hits += 1;
            plateAppearances += 1;
            atBats += 1;
        }

        public void AddHit(int rbi)
        {
            hits += 1;
            plateAppearances += 1;
            atBats += 1;
            rbis += rbi;
        }

        public float BattingAverage()
        {
            return (hits / atBats);
        }

        public float SluggingAverage()
        {
            int slgHits = hits - doubles - triples - homeRuns;
            int numerator = slgHits + 2 * doubles + 3 * triples + 4 * homeRuns;
            return (numerator / atBats);
        }

        public float OnBasePercentage()
        {
            int numerator = hits + walks;
            int denominator = 1;
            try
            {
                denominator = atBats + walks + outsTaken[OutTypes.Sacrifice];
            }
            catch { denominator = atBats + walks; }

            return (numerator / denominator);
        }

        public float OnbasePlusSlugging()
        {
            return this.OnBasePercentage() + this.SluggingAverage();
        }

        public void Collate(Batter newSelf)
        {
            if(_id != newSelf._id) { return; } //not same person
            plateAppearances += newSelf.plateAppearances;
            atBats += newSelf.atBats;
            rbis += newSelf.rbis;
            hits += newSelf.hits;
            homeRuns += newSelf.homeRuns;
            walks += newSelf.walks;
            doubles += newSelf.doubles;
            triples += newSelf.triples;

            outsTaken[OutTypes.CaughtStealing] += newSelf.outsTaken[OutTypes.CaughtStealing];
            outsTaken[OutTypes.DoublePlay] += newSelf.outsTaken[OutTypes.DoublePlay];
            outsTaken[OutTypes.FieldersChoice] += newSelf.outsTaken[OutTypes.FieldersChoice];
            outsTaken[OutTypes.Flyout] += newSelf.outsTaken[OutTypes.Flyout];
            outsTaken[OutTypes.Groundout] += newSelf.outsTaken[OutTypes.Groundout];
            outsTaken[OutTypes.Sacrifice] += newSelf.outsTaken[OutTypes.Sacrifice];
            outsTaken[OutTypes.Strikeout] += newSelf.outsTaken[OutTypes.Strikeout];
            //foreach(KeyValuePair<OutTypes, int> outCount in newSelf.outsTaken)
            //{
            //    if (!outsTaken.ContainsKey(outCount.Key)) { outsTaken.Add(outCount.Key, 0); }

            //    outsTaken[outCount.Key] += outCount.Value;
            //}
        }
    }

    public class Pitcher : Player
    {
        public Pitcher() { }
        public Pitcher(string id)
        {
            _id = id;
        }
        public float inningsPitched { get; set; }
        public int outsRecorded { get; set; }
        public int pitchCount { get; set; }
        public int strikeouts { get; set; }
        public int runs { get; set; }
        public int games { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }

        public void AddOut()
        {
            pitchCount += 1;
            outsRecorded += 1;
            IPCalc();
        }

        void IPCalc()
        {
            float partialInning = outsRecorded % 3;
            inningsPitched = ((float)outsRecorded - partialInning)/3 + (partialInning / 10); //this will give full innings, and then either .0, .1, or .2 
        }

        public float ERA()
        {
            return runs / (outsRecorded / 27);
        }

        public float WalksHitsperInningPitched()
        {
            int numerator = walks + hits;
            float denominator = outsRecorded / 3;
            return (float)numerator / denominator;
        }

        public void Collate(Pitcher newSelf)
        {
            if (_id != newSelf._id) { return; } //not same person
            hits += newSelf.hits;
            homeRuns += newSelf.homeRuns;
            walks += newSelf.walks;
            outsRecorded += newSelf.outsRecorded;
            IPCalc();
            pitchCount += newSelf.pitchCount;
            strikeouts += newSelf.strikeouts;
            runs += newSelf.runs;
            games += newSelf.games;
            wins += newSelf.wins;
            losses += newSelf.losses;
        }
    }

    public enum OutTypes
    {
        Flyout,
        Groundout,
        FieldersChoice,
        Sacrifice,
        Strikeout,
        DoublePlay,
        CaughtStealing
    }
}
