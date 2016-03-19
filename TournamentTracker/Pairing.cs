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
        private int winningPlayer;
        private int onePlayerCP;
        private int twoPlayerCP;
        private int onePlayerAP;
        private int twoPlayerAP;
        public Pairing()
        {

        }
        public Pairing(Player playerIn1,Player playerIn2, int tableNum)
        {
            this.myPlayer1 = playerIn1;
            this.myPlayer2 = playerIn2;
            this.myTable = tableNum;
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
