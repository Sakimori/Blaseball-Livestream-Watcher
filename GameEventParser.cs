using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaseball_Livestream
{
    /// <summary>
    /// Basic parser that takes Game json updates and emits GameEvent json objects
    /// PLEASE NOTE this is probably wrong; I'm currently emitting one GameEvent per game update but
    /// ultimately we want a Retrosheet-style condensed description of the whole "play" as a single GameEvent
    /// </summary>
    class GameEventParser
    {
        // Last state we saw, for comparison
        Game m_oldState;

        // State tracking for stats not tracked inherently in the state updates
        int m_eventIndex = 0;
        string m_currentBatter = null;
        string m_currentBatterName = null;
        string m_currentBatterTeam = null;
        string m_currentPitcher = null;
        string m_currentPitcherName = null;
        string m_currentPitcherTeam = null;
        int m_numFouls = 0;

        public void StartNewGame(Game initState)
        {
            m_oldState = initState;
            m_eventIndex = 0;
            m_currentBatter = null;
            m_currentBatterName = null;
            m_currentBatterTeam = null;
            m_currentPitcher = initState.awayPitcher;
            m_currentPitcherName = initState.awayPitcherName;
            m_currentPitcherTeam = initState.awayTeam;
            m_numFouls = 0;
        }

        private void UpdateBatterAndPitcher(Game newState)
        {
            // Pitchers
            if(m_oldState.inning != newState.inning || m_oldState.topOfInning != newState.topOfInning)
            {
                if(newState.topOfInning)
                {
                    m_currentPitcher = newState.awayPitcher;
                    m_currentPitcherTeam = newState.awayTeam;
                }
                else
                {
                    m_currentPitcher = newState.homePitcher;
                    m_currentPitcherTeam = newState.homeTeam;
                }
            }
            // Batters
            string batter = "";
            string batterTeam = "";
            if(newState.topOfInning)
            {
                batter = newState.awayBatter;
                batterTeam = newState.awayTeam;
            }
            else
            {
                batter = newState.homeBatter;
                batterTeam = newState.homeTeam;
            }

            // Did the batter change?
            if(batter != "" && batter != m_currentBatter)
            {
                m_currentBatter = batter;
                m_currentBatterTeam = batterTeam;
                m_numFouls = 0;
            }
        }

        public GameEvent ParseGameUpdate(Game newState)
        {
            GameEvent currEvent = new GameEvent();

            currEvent.gameId = newState._id;
            currEvent.eventIndex = m_eventIndex;
            currEvent.inning = newState.inning;
            currEvent.outsBeforePlay = m_oldState.halfInningOuts;

            UpdateBatterAndPitcher(newState);
            currEvent.batterId = m_currentBatter;
            currEvent.batterTeamId = m_currentBatterTeam;
            currEvent.pitcherId = m_currentPitcher;
            currEvent.pitcherTeamId = m_currentPitcherTeam;

            currEvent.homeScore = newState.homeScore;
            currEvent.awayScore = newState.awayScore;
            currEvent.homeStrikeCount = newState.homeStrikes;
            currEvent.awayStrikeCount = newState.awayStrikes;

            currEvent.totalStrikes = newState.atBatStrikes;
            currEvent.totalBalls = newState.atBatBalls;

            if(newState.lastUpdate.Contains("Foul Ball"))
            {
                m_numFouls++;
            }
            currEvent.totalFouls = m_numFouls;

            // TODO This doesn't work for the third out - outs never reach 3
            currEvent.outsOnPlay = Math.Max(0, newState.halfInningOuts - m_oldState.halfInningOuts);

            // Do we need a better method to track RBIs?
            // Stealing home can happen, for one thing
            currEvent.runsBattedIn = newState.topOfInning ? newState.awayScore - m_oldState.awayScore : newState.homeScore - m_oldState.homeScore;

            // Extremely basic single/double/triple/HR detection
            if (newState.lastUpdate.Contains("hits a Single"))
            {
                currEvent.basesHit = 1;
                currEvent.batterBaseAfterPlay = 1;
            }
            else if(newState.lastUpdate.Contains("hits a Double"))
            {
                currEvent.basesHit = 2;
                currEvent.batterBaseAfterPlay = 2;
            }
            else if(newState.lastUpdate.Contains("hits a Triple"))
            {
                currEvent.basesHit = 3;
                currEvent.batterBaseAfterPlay = 3;
            }
            else if(newState.lastUpdate.Contains("home run") || newState.lastUpdate.Contains("grand slam"))
            {
                currEvent.basesHit = 4;
                currEvent.batterBaseAfterPlay = 4;
            }

            // Sacrifice outs
            if(newState.lastUpdate.Contains("sacrifice"))
            {
                currEvent.isSacrificeHit = true;
            }
            
            // Double plays
            if(newState.lastUpdate.Contains("double play"))
            {
                currEvent.isDoublePlay = true;
            }

            // Triple plays
            if(newState.lastUpdate.Contains("triple play"))
            {
                currEvent.isTriplePlay = true;
            }

            // TODO currEvent.eventType
            // TODO currEvent.batterCount
            // TODO currEvent.pitchesList
            // TODO currEvent.isLeadoff
            // TODO currEvent.lineupPosition
            // TODO currEvent.battedBallType
            // TODO currEvent.baseRunners
            // TODO currEvent.isLastEventForAtBat

            // Unsure if this is enough
            currEvent.isLastGameEvent = newState.gameComplete;

            // Currently not supported by the cultural event of Blaseball
            currEvent.isPinchHit = false;
            currEvent.isWildPitch = false;
            currEvent.isBunt = false;
            currEvent.errorsOnPlay = 0;
            currEvent.isSacrificeFly = false; // I think we can't tell this

            // Store original update text for reference
            currEvent.additionalContext = newState.lastUpdate;

            m_oldState = newState;
            m_eventIndex++;

            return currEvent;
        }

        
    }
}
