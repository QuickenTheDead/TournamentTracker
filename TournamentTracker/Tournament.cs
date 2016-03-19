/*
 * User: cittah
 * Date: 18/03/2016
 * Time: 4:55 PM
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 
    namespace TournamentTracker
{
    /// <summary>
    /// Description of Tournament.
    /// </summary>
    class Tournament
    {
        private List<Player> playerList = new List<Player>();
        private List<Round> roundList = new List<Round>();
        public Tournament(List<Player> players)
        {
            this.playerList = players;
            Round round = new Round(players, 1);
            round.StartRound();
            roundList.Add(round);

        }

        public List<Player> PlayerList
        {
            get
            {
                return playerList;
            }

            set
            {
                playerList = value;
            }
        }

        internal List<Round> RoundList
        {
            get
            {
                return roundList;
            }

            set
            {
                roundList = value;
            }
        }
    }
}
