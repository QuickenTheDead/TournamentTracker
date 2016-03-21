/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 8:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace TournamentTracker
{
    /// <summary>
    /// Description of Player.
    /// </summary>
    public class Player : IComparable<Player>

    {
        private string myFirstName;
        private string myLastName;
        private string myFaction;
        private string myDisplayName;
        private bool dropped;
        private int wins;
        private int loses;
        private int controlPoints;
        private int armyPointsDestroyed;
        private int sOS;
        private int uid;
        private string myDisplayNameWins;
        public List<int> oppGuids = new List<int>();
        public Player()
        {

        }
        public Player(string firstNm, string lastNm, string fact)
        {
            this.myFirstName = firstNm;
            this.myLastName = lastNm;
            this.myFaction = fact;
            this.myDisplayName = firstNm + " " + lastNm + " " + " (" + fact + ")";
            this.myDisplayNameWins = firstNm + " " + lastNm + " " + " (" + fact + ") (0)";
            wins = 0;
            loses = 0;
            controlPoints = 0;
            armyPointsDestroyed = 0;
            sOS = 0;
            dropped = false;
        }
        public string firstName
        {
            get
            {
                return myFirstName;
            }
            set
            {
                myFirstName = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " (" + myFaction + ")";
            }
        }

        public string lastName
        {
            get
            {
                return myLastName;
            }
            set
            {
                myLastName = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " (" + myFaction + ")";
            }
        }
        public string faction
        {
            get
            {
                return myFaction;
            }
            set
            {
                myFaction = value;
                myDisplayName = myFirstName + " " + myLastName + " " + " (" + myFaction + ")";
            }
        }
        public string displayName
        {
            get
            {
                return myDisplayName;
            }
        }

        public int ControlPoints
        {
            get
            {
                return controlPoints;
            }

            set
            {
                controlPoints = value;
            }
        }

        public int ArmyPointsDestroyed
        {
            get
            {
                return armyPointsDestroyed;
            }

            set
            {
                armyPointsDestroyed = value;
            }
        }

        public int Wins
        {
            get
            {
                return wins;
            }

            set
            {
                wins = value;
                myDisplayNameWins = myFirstName + " " + myLastName + " " + " (" + myFaction + ")" + " (" + wins + ")";
            }
        }

        public int Loses
        {
            get
            {
                return loses;
            }

            set
            {
                loses = value;
            }
        }

        public bool Dropped
        {
            get
            {
                return dropped;
            }

            set
            {
                dropped = value;
            }
        }

        public int Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }

        public string MyDisplayNameWins
        {
            get
            {
                return myDisplayNameWins;
            }

        }

        public int SOS
        {
            get
            {
                return sOS;
            }

            set
            {
                sOS = value;
            }
        }

        public List<int> OppGuids
        {
            get
            {
                return oppGuids;
            }

            set
            {
                oppGuids = value;
            }
        }
        public int CompareTo(Player comparePlayer)
        {
            // A null value means that this object is greater.
            if (comparePlayer == null)
                return 1;

            if (this.wins == comparePlayer.Wins)
                if (this.SOS == comparePlayer.SOS)
                    if (this.controlPoints == comparePlayer.controlPoints)
                        return comparePlayer.armyPointsDestroyed.CompareTo(this.armyPointsDestroyed);
                    else
                        return comparePlayer.controlPoints.CompareTo(this.controlPoints);
                else
                    return comparePlayer.SOS.CompareTo(this.SOS);
            
            

            return comparePlayer.Wins.CompareTo(this.Wins);
            
        }
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    Player objAsPlayer = obj as Player;
        //    if (objAsPlayer == null) return false;
        //    else return Equals(objAsPlayer);
        //}
        //public bool Equals(Player other)
        //{
        //    if (other == null) return false;
        //    return (this.Wins.Equals(other.Wins));
        //}

    }
}
