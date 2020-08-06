﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaseball_Livestream
{
    abstract class Player
    {
        public Player() { }

        public string _id { get; set; } = null;
        public string name { get; set; } = null;
        public bool deceased { get; set; }
        public int hits { get; set; }
        public int homeRuns { get; set; }
        public int walks { get; set; }
    }

    class Batter : Player
    {
        public Batter() { }
        public Batter(string id)
        {
            _id = id;
        }
        public int plateAppearances { get; set; }
        public int atBats { get; set; }
        public int rbis { get; set; }
        public Dictionary<OutTypes,int> outsTaken { get; set; }
        public int stolenBases { get; set; }
        public int caughtStealing { get; set; }

        //Adding outs will automatically track atbats and plate appearances
        public void AddOut(OutTypes outType)
        {
            outsTaken[outType] += 1;
            if(outType != OutTypes.CaughtStealing)
            {
                plateAppearances += 1;
                if(outType != OutTypes.Sacrifice) { atBats += 1; }
            }
            outsTaken[outType] += 1;
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

    class Pitcher : Player
    {
        public Pitcher() { }
        public Pitcher(string id)
        {
            _id = id;
        }
        public float inningsPitched { get; set; }
        public int outsRecorded { get; set; }
        public int pitchCount { get; set; }
        public int hitsOn2Outs { get; set; }
        public int runsOn2Outs { get; set; }
        public int runnersStranded { get; set; }
        public int strikeouts { get; set; }

        public void AddOut()
        {
            pitchCount += 1;
            outsRecorded += 1;
        }
    }

    enum OutTypes
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