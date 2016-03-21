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
        public void createPairings()
        {
            if(roundNumber==0)
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
                                    newPair.WinningPlayer = 1;
                                    newPair.Finished = true;

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
            else
            {
                List<Player> subPairList = new List<Player>();
                int tableCount = 0;
                bool successfulPairing = false;
                while (!successfulPairing)
                {
                    successfulPairing = true;
                    for (int x = roundNumber; x >= 0; x--)
                    {
                        int playerNum = -1;
                        foreach (Player plyr in playersList)
                        {
                            if (plyr.Wins == x)
                            {
                                subPairList.Add(plyr);
                            }
                        }

                        foreach (Player player in subPairList)
                        {
                            playerNum++;
                            bool playerPaired = false;
                            foreach (Pairing pair in pairingList)
                            {
                                if (pair.Player1 == player || pair.Player2 == player || player.Dropped == true)
                                {
                                    playerPaired = true;
                                }

                            }
                            if (!playerPaired)
                            {
                                //CHECK IF WE HAVE A PAIRDOWN
                                int playersleft = 0;
                                int leftIndex = -1;

                                foreach (Player ply in subPairList)
                                {
                                    bool playerLeftPairCountBool = false;
                                    leftIndex++;
                                    foreach (Pairing pair in pairingList)
                                    {
                                        if (pair.Player1 == subPairList[leftIndex] || pair.Player2 == subPairList[leftIndex])
                                        {
                                            playerLeftPairCountBool = true;
                                        }

                                    }
                                    if (!playerLeftPairCountBool && ply.Dropped == false)
                                        playersleft++;
                                }
                                if (playersleft != 1)
                                {
                                    //If player isnt paired
                                    
                                    while (!playerPaired)
                                    {
                                        bool alreadyPlayed = true;
                                        bool RndPlayerAlreadyPaired;
                                        int playerIndex=0;
                                        while (alreadyPlayed)
                                        {
                                            alreadyPlayed = false;
                                            Random rnd = new Random();
                                            playerIndex = rnd.Next(playerNum + 1, subPairList.Count);


                                            //Reset if Players play each other
                                            //TODO
                                            foreach (int guid in player.oppGuids)
                                            {
                                                if (guid == subPairList[playerIndex].Uid)
                                                {
                                                    alreadyPlayed = true;
                                                    //TODO:WHAT IF THE players has already played the last 3 players? 4? etc.
                                                    if (playersleft == 2)
                                                    {
                                                        successfulPairing = false;
                                                        
                                                    }
                                                }
                                            }
                                            if(!successfulPairing)
                                                break;
                                        }
                                        if (successfulPairing)
                                        {
                                            RndPlayerAlreadyPaired = false;
                                            foreach (Pairing pair in pairingList)
                                            {
                                                if (pair.Player1 == subPairList[playerIndex] || pair.Player2 == subPairList[playerIndex])
                                                {
                                                    RndPlayerAlreadyPaired = true;
                                                }

                                            }

                                            if (!RndPlayerAlreadyPaired && subPairList[playerIndex].Dropped == false)
                                            {
                                                Pairing newPair = new Pairing();
                                                newPair.Player1 = player;
                                                newPair.Player2 = subPairList[playerIndex];
                                                if (subPairList[playerIndex].Uid == 50)
                                                {
                                                    newPair.Table = 0;
                                                    newPair.WinningPlayer = 1;
                                                    newPair.Finished = true;

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
                                        if (!successfulPairing)
                                            break;
                                    }
                                }

                            }
                            if (!successfulPairing)
                                break;
                        }
                        if (!successfulPairing)
                            break;
                    }
                }
                pairingList.Sort();
            }
        }

    }
}
