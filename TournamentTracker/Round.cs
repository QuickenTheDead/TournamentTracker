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
using System.Linq;
using System.Text;

namespace TournamentTracker
{
    /// <summary>
	/// Description of Player.
	/// </summary>
    class Round
    {
        private List<Player> playersList = new List<Player>();
        private List<Pairing> pairingList = new List<Pairing>();
        private int roundNumber;

        public List<Player> PlayersList
        {
            get
            {
                return playersList;
            }

            set
            {
                playersList = value;
            }
        }

        internal List<Pairing> PairingList
        {
            get
            {
                return pairingList;
            }

            set
            {
                pairingList = value;
            }
        }

        public Round(List<Player> players, int rndNum)
        {
            this.playersList = players;
            this.roundNumber = rndNum;
        }
        public void StartRound()
        {
            if(roundNumber==1)
            {
                int playerNum = -1;
                int tableCount = 0;   
                foreach(Player player in playersList)
                {
                    playerNum++;
                    bool playerPaired = false;
                    foreach (Pairing pair in pairingList)
                    {
                        if(pair.Player1==player || pair.Player2 == player)
                        {
                            playerPaired = true;
                        }

                    } 
                    if (!playerPaired)
                    {

                        while(!playerPaired)
                        {
                           Random rnd = new Random();
                           int playerIndex = rnd.Next(playerNum+1, playersList.Count);
                           bool RndPlayerAlreadyPaired = false;
                           foreach (Pairing pair in pairingList)
                           {
                                if (pair.Player1 == playersList[playerIndex] || pair.Player2 == playersList[playerIndex])
                                {
                                    RndPlayerAlreadyPaired = true;
                                }

                           }
                           if(!RndPlayerAlreadyPaired)
                           {
                                Pairing newPair = new Pairing();
                                newPair.Player1 = player;
                                newPair.Player2 = playersList[playerIndex];
                                if (playersList[playerIndex].firstName == "BYE" && playersList[playerIndex].lastName == "")
                                {
                                    newPair.Table = 0;
                                }
                                else
                                {
                                    tableCount++;
                                    newPair.Table = tableCount;
                                }
                                pairingList.Add(newPair);
                                playerPaired = true;
                            }
                        }
                        
                    }
                }
                pairingList.Sort();
            }
        }

    }
}
