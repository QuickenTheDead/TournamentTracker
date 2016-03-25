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
using System.Threading;

namespace TournamentTracker
{
    /// <summary>
	/// Description of Player.
	/// </summary>
    public class Round
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

        public List<Pairing> PairingList
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
        
        #region NewPairingLogic
        public void createPairings()
        {
            List<Player> subPairList = new List<Player>();
            List<Player> pairListFinal = new List<Player>();
            int tableCount = 1;
            
            for (int x = roundNumber; x >= 0; x--)
            {
                Player savePlayer = new Player("NA", "NA", "NA");
                if(subPairList.Count==1)
                {
                    savePlayer = subPairList[0];
                    subPairList.Clear();
                }
                //Load Players into the sublist
                foreach (Player plyr in playersList)
                {
                    if (plyr.Wins == x && plyr.Uid != 50 && plyr.Dropped == false)
                    {
                        subPairList.Add(plyr);
                    }
                }
                bool successfullPairing = false;
                int iterations = 0;
                while (!successfullPairing)
                {
                    successfullPairing = true;
                    subPairList.Shuffle();
                    if (savePlayer.faction != "NA")
                    {
                        subPairList.Insert(0, savePlayer);
                    }
                    if (x == 0)
                    {
                        //Add BUY player
                        //Put winner on top
                        foreach (Player findBuyPlyr in playersList)
                        {
                            if (findBuyPlyr.Uid == 50)
                                subPairList.Add(findBuyPlyr);
                                
                        }
                    }
                    for (int y = 0; y <= subPairList.Count-1; y = y + 2)
                    {
                        if (subPairList.Count != y + 1)
                        {
                            foreach (int uid in subPairList[y].oppGuids)
                            {
                                if (uid == subPairList[y + 1].Uid)
                                {
                                    successfullPairing = false;
                                }
                            }
                        }
                    }
                    iterations++;
                    if (iterations == 50)
                        successfullPairing = true;
                }
                
                //Set count var to the number of players
                int count = subPairList.Count;
                //If we have an odd numebr of players in this sub list, it'll carry over to the next pairing process
                //This happens during a pair down
                if (IsOdd(count))
                    count--;
                //remove 1 from count since we use 0 based indexs
                count--;
                
                for (int n = 0; n <= count; n++)
                {
                    pairListFinal.Add(subPairList[0]);
                    subPairList.Remove(subPairList[0]);
                }
                
                
            }
            for (int z = 0; z < pairListFinal.Count-1; z=z+2)
            {
                Pairing newPair = new Pairing();
                newPair.Player1 = pairListFinal[z];
                newPair.Player2 = pairListFinal[z+1];
                
                if (pairListFinal[z].Uid == 50 || pairListFinal[z+1].Uid == 50)
                    newPair.Table = 0;
                else
                    newPair.Table = tableCount;

                pairingList.Add(newPair);
                tableCount++;
            }
        }
        #endregion NewPairingLogic
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        #region OldPairing Logic
        //<summary> No Longer Used
        //</summary> 
        public void createPairingsOld()
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
                        //Load Players into the sublist
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
                            List<Player> listPlayersLeft = new List<Player>();
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
                                        if (pair.Player1 == subPairList[leftIndex])
                                        {
                                            listPlayersLeft.Add(pair.Player1);
                                            playerLeftPairCountBool = true;
                                        }
                                        else if (pair.Player2 == subPairList[leftIndex])
                                        {
                                            playerLeftPairCountBool = true;
                                            listPlayersLeft.Add(pair.Player1);
                                        }

                                    }
                                    if (!playerLeftPairCountBool && ply.Dropped == false)
                                        playersleft++;
                                }
                                //TODO: 
                                //See if all players.oppguid =  all playersLeft.guid
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
    #endregion OldPairing Logic
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
