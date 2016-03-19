using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentTracker
{
    class Pairing : IComparable<Pairing>
    {
        private Player myPlayer1 = new Player();
        private Player myPlayer2 = new Player();
        private int myTable;
        private int winningPlayer;
        private int winningPlayerCP;
        private int losingPlayerCP;
        private int winningPlayerAP;
        private int losingPlayerAP;
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

        public int WinningPlayerCP
        {
            get
            {
                return winningPlayerCP;
            }

            set
            {
                winningPlayerCP = value;
            }
        }

        public int LosingPlayerCP
        {
            get
            {
                return losingPlayerCP;
            }

            set
            {
                losingPlayerCP = value;
            }
        }

        public int WinningPlayerAP
        {
            get
            {
                return winningPlayerAP;
            }

            set
            {
                winningPlayerAP = value;
            }
        }

        public int LosingPlayerAP
        {
            get
            {
                return losingPlayerAP;
            }

            set
            {
                losingPlayerAP = value;
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
