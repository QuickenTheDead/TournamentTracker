using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentTracker
{
    public class Pairing : IComparable<Pairing>
    {
        private Player myPlayer1 = new Player();
        private Player myPlayer2 = new Player();
        private int myTable;
        private int winningPlayer= 0;
        private int onePlayerCP = 0;
        private int twoPlayerCP = 0;
        private int onePlayerAP= 0;
        private int twoPlayerAP= 0;
        private bool finished = false;
        public Pairing()
        {

        }
        public Pairing(ref Player playerIn1, ref Player playerIn2)
        {
            this.myPlayer1 = playerIn1;
            this.myPlayer2 = playerIn2;
            
        }

        public Player Player2
        {
            get
            {
                return myPlayer2;
            }

            set
            {
                myPlayer2 = value;
            }
        }

        public int Table
        {
            get
            {
                return myTable;
            }

            set
            {
                myTable = value;
            }
        }

        public Player Player1
        {
            get
            {
                return myPlayer1;
            }
            set
            {
                myPlayer1 = value;
            }
        }

        public int WinningPlayer
        {
            get
            {
                return winningPlayer;
            }

            set
            {
                winningPlayer = value;
            }
        }

        public int OnePlayerCP
        {
            get
            {
                return onePlayerCP;
            }

            set
            {
                onePlayerCP = value;
            }
        }

        public int TwoPlayerCP
        {
            get
            {
                return twoPlayerCP;
            }

            set
            {
                twoPlayerCP = value;
            }
        }

        public int OnePlayerAP
        {
            get
            {
                return onePlayerAP;
            }

            set
            {
                onePlayerAP = value;
            }
        }

        public int TwoPlayerAP
        {
            get
            {
                return twoPlayerAP;
            }

            set
            {
                twoPlayerAP = value;
            }
        }

        public bool Finished
        {
            get
            {
                return finished;
            }

            set
            {
                finished = value;
            }
        }

        public int CompareTo(Pairing comparePair)
        {
            // A null value means that this object is greater.
            if (comparePair == null)
                return 1;

            else
                return this.Table.CompareTo(comparePair.Table);
        }
    }
}
