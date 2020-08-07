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
        public Dictionary<OutTypes, int> outsTaken { get; set; } = new Dictionary<OutTypes, int>();
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

        public void AddOut()
        {
            pitchCount += 1;
            outsRecorded += 1;
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
