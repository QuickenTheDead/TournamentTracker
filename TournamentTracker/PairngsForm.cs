/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 15/03/2016
 * Time: 10:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace TournamentTracker
{
	/// <summary>
	/// Description of PairngsForm.
	/// </summary>
	public partial class PairngsForm : Form
	{
        Tournament tourny;
        int index;
        ResultsRecorderForm resultsForm;
        dropSwapForm dropSwapForm;
        SwapForm swapform;
        TableForm tableform;
        List<string> columns = new List<string>();
        int round= 0;
        Player swapPlayerSave;
        public PairngsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        public PairngsForm(List<Player> players, string name)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            
            InitializeComponent();
            tourny = new Tournament(players, name);
            
            this.Text = tourny.Name;
            columns.Add("Table");
            columns.Add("Player1");
            columns.Add("Player2");
            columns.Add("Complete");
            //refreshDataGridView();
            roundgroupBox.Text = "Round " + (round + 1);

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void PairngsFormLoad(object sender, EventArgs e)
		{
            refreshDataGridView();
            previousRoundButton.Enabled = false;
            nextRoundbutton.Enabled = false;
        }
        void resultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (resultsForm.actionType != "Cancel")
            {
                int oneIndex = tourny.PlayerList.FindIndex(x => x.Uid.Equals(tourny.RoundList[round].PairingList[index].Player1.Uid));
                int twoIndex = tourny.PlayerList.FindIndex(x => x.Uid.Equals(tourny.RoundList[round].PairingList[index].Player2.Uid));

                if (tourny.RoundList[round].PairingList[index].Finished == true)
                {
                    tourny.PlayerList[oneIndex].ArmyPointsDestroyed -= tourny.RoundList[round].PairingList[index].OnePlayerAP;
                    tourny.PlayerList[oneIndex].ControlPoints -= tourny.RoundList[round].PairingList[index].OnePlayerCP;
                    tourny.PlayerList[twoIndex].ArmyPointsDestroyed -= tourny.RoundList[round].PairingList[index].TwoPlayerAP;
                    tourny.PlayerList[twoIndex].ControlPoints -= tourny.RoundList[round].PairingList[index].TwoPlayerCP;
                    if (tourny.RoundList[round].PairingList[index].WinningPlayer == 1)
                    {
                        tourny.PlayerList[oneIndex].Wins--;
                    }
                    else
                    {
                        tourny.PlayerList[twoIndex].Wins--;
                    }
                }
                else
                {
                    tourny.PlayerList[oneIndex].oppGuids.Add(tourny.PlayerList[twoIndex].Uid);
                    tourny.PlayerList[twoIndex].oppGuids.Add(tourny.PlayerList[oneIndex].Uid);
                }
                
                    if (resultsForm.winningplayer == 1)
                    {
                        tourny.PlayerList[oneIndex].Wins++;
                        tourny.RoundList[round].PairingList[index].WinningPlayer = 1;

                    }
                    else
                    {
                        tourny.PlayerList[twoIndex].Wins++;
                        tourny.RoundList[round].PairingList[index].WinningPlayer = 2;
                    }
                    //Set Round Pairing Variables
                    tourny.RoundList[round].PairingList[index].OnePlayerAP = resultsForm.oneAP;
                    tourny.RoundList[round].PairingList[index].OnePlayerCP = resultsForm.oneCP;
                    tourny.RoundList[round].PairingList[index].TwoPlayerAP = resultsForm.twoAP;
                    tourny.RoundList[round].PairingList[index].TwoPlayerCP = resultsForm.twoCP;

                    //Add to player variables
                    tourny.PlayerList[oneIndex].ArmyPointsDestroyed += resultsForm.oneAP; 
                    tourny.PlayerList[oneIndex].ControlPoints += resultsForm.oneCP;
                    tourny.PlayerList[twoIndex].ArmyPointsDestroyed += resultsForm.twoAP;
                    tourny.PlayerList[twoIndex].ControlPoints += resultsForm.twoCP;
                

                    tourny.RoundList[round].PairingList[index].Finished = true;
                    bool roundFinished = true;
                    foreach (Pairing pair in tourny.RoundList[round].PairingList)
                    {
                        if (pair.Finished == false)
                        {
                            roundFinished = false;
                        }
                    }
                    if (roundFinished)
                    {
                        nextRoundbutton.Enabled = true;
                    }
                
                refreshDataGridView();
            }

        }
        void dropSwap_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (dropSwapForm.actionType == "Drop")
            {
                int indexCount = 0;
                int buyindex = -1;

                foreach (Player plyr in tourny.PlayerList)
                {
                    if (plyr.Uid == dropSwapForm.player.Uid)
                        plyr.Dropped = true;
                    if (plyr.Uid == 50)
                        buyindex = indexCount;
                    indexCount++;
                }
                bool buyPlayerRemoved = false;
                if (buyindex != -1)
                {
                    tourny.PlayerList.Remove(tourny.PlayerList[buyindex]);
                    tourny.RoundList[round].PairingList.Remove(tourny.RoundList[round].PairingList[index]);
                    buyPlayerRemoved = true;
                }
                else
                {
                    Player ByePlayer = new Player("BYE", "", "");
                    ByePlayer.Uid = 50;
                    tourny.PlayerList.Add(ByePlayer);
                }
                DialogResult result = MessageBox.Show("Would You Like To Automatically Reassign Pairings? \nSelecting 'No' will allow you to edit pairings manually", "Pairing Resignment", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    if (buyPlayerRemoved == false)
                    {
                        if (dropSwapForm.playernumber == 1)
                            tourny.RoundList[round].PairingList[index].Player1 = tourny.PlayerList[tourny.PlayerList.Count - 1];
                        else if (dropSwapForm.playernumber == 2)
                            tourny.RoundList[round].PairingList[index].Player2 = tourny.PlayerList[tourny.PlayerList.Count - 1];
                    }
                }
                else
                {
                    tourny.RoundList[round].PairingList.Clear();
                    tourny.RoundList[round].createPairings();
                }
                refreshDataGridView();
            }
            else if (dropSwapForm.actionType == "Swap")
            {
                swapform = new SwapForm(tourny.PlayerList, swapPlayerSave);
                swapform.FormClosed += new FormClosedEventHandler(SwapForn_FormClosed);
                swapform.Show();
            }
        
        }
        void SwapForn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (swapform.actionType == "Accept")
            {
                Pairing pair1 = new Pairing();
                Pairing pair2 = new Pairing();
                int thisIndex = 0;
                int pair1Index = -1;
                int pair2Index = -1;
                foreach (Pairing pair in tourny.RoundList[round].PairingList)
                {
                    if (pair.Player1.Uid == swapform.swapPlayer.Uid)
                    {
                        pair1 = pair;
                        pair1.Player1 = swapform.selectedPlayer;
                        pair1Index = thisIndex;
                    }
                    else if (pair.Player1.Uid == swapform.selectedPlayer.Uid)
                    {
                        pair2 = pair;
                        pair2.Player1 = swapform.swapPlayer;
                        pair2Index = thisIndex;
                    }
                    if (pair.Player2.Uid == swapform.swapPlayer.Uid)
                    {
                        pair1 = pair;
                        pair1.Player2 = swapform.selectedPlayer;
                        pair1Index = thisIndex;
                    }

                    else if (pair.Player2.Uid == swapform.selectedPlayer.Uid)
                    {
                        pair2 = pair;
                        pair2.Player2 = swapform.swapPlayer;
                        pair2Index = thisIndex;
                    }
                    thisIndex++;
                }
                if (pair1Index == pair2Index)
                {
                    //Player savePlayer1;
                    //savePlayer1 = tourny.RoundList[round].PairingList[pair1Index].Player1;
                    //tourny.RoundList[round].PairingList[pair1Index].Player1 = tourny.RoundList[round].PairingList[pair1Index].Player2;
                    //tourny.RoundList[round].PairingList[pair1Index].Player2 = savePlayer1;

                }
                else
                {
                    tourny.RoundList[round].PairingList[pair1Index] = pair1;
                    tourny.RoundList[round].PairingList[pair2Index] = pair2;
                }
                refreshDataGridView();
            }
        }
        void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(tableform.actionType=="Accept")
                tourny.RoundList[round].PairingList[index].Table = tableform.tableNum;
            refreshDataGridView();
        }
        private void pairDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            index = e.RowIndex;
            if (e.ColumnIndex == 3)
            {
                resultsForm = new ResultsRecorderForm(tourny.RoundList[round].PairingList[index]);
                resultsForm.FormClosed += new FormClosedEventHandler(resultsForm_FormClosed);
                resultsForm.Show();
            }
            else if (e.ColumnIndex == 0)
            {
                tableform = new TableForm();
                tableform.FormClosed += new FormClosedEventHandler(TableForm_FormClosed);
                tableform.Show();
            }
            else if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                if (tourny.RoundList[round].PairingList[index].Finished == true)
                {
                    MessageBox.Show("Cannot Edit Pairing that has already finished", "Error Message");
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        dropSwapForm = new dropSwapForm(tourny.RoundList[round].PairingList[index].Player1, 1);
                        swapPlayerSave = tourny.RoundList[round].PairingList[index].Player1;
                    }
                    else
                    {
                        dropSwapForm = new dropSwapForm(tourny.RoundList[round].PairingList[index].Player2, 2);
                        swapPlayerSave = tourny.RoundList[round].PairingList[index].Player2;
                    }
                    dropSwapForm.FormClosed += new FormClosedEventHandler(dropSwap_FormClosed);
                    dropSwapForm.Show();
                }
            }
        }
        public DataTable GetResultsTable()
        {
            // Create the output table.
            DataTable d = new DataTable();
            // Loop through all process names.
            foreach (String col in columns)
            {
                // The current process name.
                string name = col;

                // Add the program name to our columns.
                d.Columns.Add(name);
            }
                 // Put every column's numbers in this List.
                tourny.RoundList[round].PairingList.Sort();
                foreach (Pairing pair in tourny.RoundList[round].PairingList)
                {
                    DataRow row = d.NewRow();
                    row["Table"] = pair.Table;
                if(round==0)
                {
                    row["Player1"] = pair.Player1.displayName;
                    row["Player2"] = pair.Player2.displayName;
                }
                else
                {
                    row["Player1"] = pair.Player1.MyDisplayNameWins;
                    row["Player2"] = pair.Player2.MyDisplayNameWins;
                }   
                    row["Complete"] = pair.Finished;
                    d.Rows.Add(row);
                }
            
            return d;
        }
        private void refreshDataGridView()
        {
            //<toDo> Initial load does not show colours
            pairingDataGridView.DataSource = null;
            pairingDataGridView.DataSource = GetResultsTable();
            pairingDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            pairingDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            int index = 0;
            foreach (DataGridViewRow row in pairingDataGridView.Rows)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                if(tourny.RoundList[round].PairingList[index].Finished == false)
                {
                    style.BackColor = Color.LightSalmon;
                    style.ForeColor = Color.Black;
                }
                else
                {
                    style.BackColor = Color.LightGreen;
                    style.ForeColor = Color.Black;
                }
                
                row.Cells[3].Style = style;
                index++;
            }

        }

        private void nextRoundbutton_Click(object sender, EventArgs e)
        {
            int winnerCount = 0;
            foreach (Player plyr in tourny.PlayerList)
            {
                if (plyr.Wins >= round+1 && plyr.Dropped ==false)
                    winnerCount++;
            }
            if (winnerCount == 1)
            {
                MessageBox.Show("There are no more undefeated players. Cannot start next round", "Error Message");
                nextRoundbutton.Enabled = false;
            }
            else
            {
                round++;
                if (tourny.RoundList.Count < round + 1)
                {
                    Round newRound = new Round(tourny.PlayerList, round);
                    newRound.createPairings();
                    tourny.RoundList.Add(newRound);

                }
                previousRoundButton.Enabled = true;
                refreshDataGridView();
                roundgroupBox.Text = "Round " + (round + 1);
                nextRoundbutton.Enabled = false;
                bool roundFinished = true;
                foreach (Pairing pair in tourny.RoundList[round].PairingList)
                {
                    if (pair.Finished == false)
                    {
                        roundFinished = false;
                    }
                }
                if (roundFinished)
                {
                    nextRoundbutton.Enabled = true;
                }
            }
        }

        private void previousRoundButton_Click(object sender, EventArgs e)
        {
            round--;
            if (round == 0)
                previousRoundButton.Enabled = false;
            roundgroupBox.Text = "Round " + (round + 1);
            nextRoundbutton.Enabled = true;
            refreshDataGridView();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            CompleteTournamentForm complete = new CompleteTournamentForm(tourny);
            complete.Show();
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
