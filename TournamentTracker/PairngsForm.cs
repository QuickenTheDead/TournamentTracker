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
using System.IO;
using Newtonsoft.Json;

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
        AddPlayerForm addForm;
        List<string> columns = new List<string>();
        int round= 0;
        Player swapPlayerSave;
        int row = 0;
        int NUM_ROWS_PER_PAGE = 20;
        int startSearch = 0;
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
        public PairngsForm(Tournament loadTourny)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            tourny = loadTourny;
            round = tourny.RoundList.Count-1;
            this.Text = tourny.Name;
            columns.Add("Table");
            columns.Add("Player1");
            columns.Add("Player2");
            columns.Add("Complete");
            //refreshDataGridView();
            for (int i = 0; i < pairingDataGridView.ColumnCount; i++)
            { pairingDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; }
            roundgroupBox.Text = "Round " + (round + 1);
            CreateMyMainMenu();

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
            for (int i = 0; i < pairingDataGridView.ColumnCount; i++)
            { pairingDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; }

            //refreshDataGridView();
            roundgroupBox.Text = "Round " + (round + 1);
            CreateMyMainMenu();
            saveTournament();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void PairngsFormLoad(object sender, EventArgs e)
		{
            refreshDataGridView();
            
            bool roundFinished = true;
            nextRoundbutton.Enabled = false;
            if (round == 0)
            {
                previousRoundButton.Enabled = false;
            }
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
                saveTournament();
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
                bool roundStarted = false;
                foreach (Pairing p in tourny.RoundList[round].PairingList)
                {
                    if (p.Finished)
                        roundStarted = true;
                }
                DialogResult result = DialogResult.No;
                if (!roundStarted)
                    result = MessageBox.Show("Would You Like To Automatically Reassign Pairings? \nSelecting 'No' will allow you to edit pairings manually", "Pairing Resignment", MessageBoxButtons.YesNo);

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
                saveTournament();
                refreshDataGridView();
            }
            else if (dropSwapForm.actionType == "Swap")
            {
                List<Player> swapPlayerList = new List<Player>();
                foreach (Pairing p in tourny.RoundList[round].PairingList)
                {
                    if (!p.Finished)
                    {
                        if (p.Player1.Uid != swapPlayerSave.Uid)
                            swapPlayerList.Add(p.Player1);
                        if (p.Player2.Uid != swapPlayerSave.Uid)
                            swapPlayerList.Add(p.Player2);
                    }
                }
                swapform = new SwapForm(swapPlayerList, swapPlayerSave);
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
                saveTournament();
                refreshDataGridView();
            }
        }
        void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(tableform.actionType=="Accept")
                tourny.RoundList[round].PairingList[index].Table = tableform.tableNum;
            saveTournament();
            refreshDataGridView();
        }
        private void pairDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            index = e.RowIndex;
            if (index != -1)
            {
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
        }
        private void SwapPlayer_MenuItemClick(object sender, EventArgs e)
        {
            Int32 selectedCellCount = pairingDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 0 || pairingDataGridView.SelectedCells[0].ColumnIndex == 0 || pairingDataGridView.SelectedCells[0].ColumnIndex == 3)
            {
                MessageBox.Show("No player selected", "Error");
            }
            else if (tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Finished == true)
            {
                    MessageBox.Show("Cannot Edit Pairing that has already finished", "Error Message");
            }
            else
            {
                if (pairingDataGridView.SelectedCells[0].ColumnIndex == 1)
                {
                    
                    swapPlayerSave = tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player1;
                }
                else
                {
                    //dropSwapForm = new dropSwapForm(tourny.RoundList[round].PairingList[index].Player2, 2);
                    swapPlayerSave = tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player2;
                }
                List<Player> swapPlayerList = new List<Player>();
                foreach(Pairing p in tourny.RoundList[round].PairingList)
                {
                    if(!p.Finished)
                    {
                        if(p.Player1.Uid != swapPlayerSave.Uid)
                            swapPlayerList.Add(p.Player1);
                        if(p.Player2.Uid != swapPlayerSave.Uid)
                            swapPlayerList.Add(p.Player2);
                    }
                }
                swapform = new SwapForm(swapPlayerList, swapPlayerSave);
                swapform.FormClosed += new FormClosedEventHandler(SwapForn_FormClosed);
                swapform.Show();
            }
            // pairingDataGridView.SelectedCells
        }
        private void dropPlayer_MenuItemClick(object sender, EventArgs e)
        {
            Int32 selectedCellCount = pairingDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 0 || pairingDataGridView.SelectedCells[0].ColumnIndex == 0 || pairingDataGridView.SelectedCells[0].ColumnIndex == 3)
            {
                MessageBox.Show("No player selected", "Error");
            }
            else if (tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Finished == true)
            {
                MessageBox.Show("Cannot Edit Pairing that has already finished", "Error Message");
            }
            else
            {
                DialogResult result1 = DialogResult.Yes;

                int indexCount = 0;
                int buyindex = -1;
                int uid = 0;
                if (pairingDataGridView.SelectedCells[0].ColumnIndex == 1)
                {
                    uid = tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player1.Uid;
                    result1 = MessageBox.Show("Are you sure you want to drop " + tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player1.displayName + "?", "Confirmation", MessageBoxButtons.YesNo);

                }
                else
                {
                    uid = tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player2.Uid;
                    result1 = MessageBox.Show("Are you sure you want to drop " + tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player2.displayName + "?", "Confirmation", MessageBoxButtons.YesNo);

                }
                if (result1 == DialogResult.Yes)
                {
                    foreach (Player plyr in tourny.PlayerList)
                    {
                        if (plyr.Uid == uid)
                            plyr.Dropped = true;
                        if (plyr.Uid == 50)
                            buyindex = indexCount;
                        indexCount++;
                    }
                    bool buyPlayerRemoved = false;
                    if (buyindex != -1)
                    {
                        tourny.PlayerList.Remove(tourny.PlayerList[buyindex]);
                        tourny.RoundList[round].PairingList.Remove(tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex]);
                        buyPlayerRemoved = true;
                    }
                    else
                    {
                        Player ByePlayer = new Player("BYE", "", "");
                        ByePlayer.Uid = 50;
                        tourny.PlayerList.Add(ByePlayer);
                    }

                    bool roundStarted = false;
                    foreach (Pairing p in tourny.RoundList[round].PairingList)
                    {
                        if (p.Finished)
                            roundStarted = true;
                    }
                    DialogResult result = DialogResult.No;
                    if (!roundStarted)
                        result = MessageBox.Show("Would You Like To Automatically Reassign Pairings? \nSelecting 'No' will allow you to edit pairings manually", "Pairing Resignment", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        if (buyPlayerRemoved == false)
                        {
                            if (pairingDataGridView.SelectedCells[0].ColumnIndex == 1)
                                tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player1 = tourny.PlayerList[tourny.PlayerList.Count - 1];
                            else if (pairingDataGridView.SelectedCells[0].ColumnIndex == 2)
                                tourny.RoundList[round].PairingList[pairingDataGridView.SelectedCells[0].RowIndex].Player2 = tourny.PlayerList[tourny.PlayerList.Count - 1];
                        }
                    }
                    else
                    {
                        tourny.RoundList[round].PairingList.Clear();
                        tourny.RoundList[round].createPairings();
                    }
                    saveTournament();
                    refreshDataGridView();
                }
            }
        }
        private void addPlayer_MenuItemClick(object sender, EventArgs e)
        {
            int guid = tourny.PlayerList[0].Uid;
            foreach (Player plyr in tourny.PlayerList)
            {
                if (plyr.Uid > guid)
                    guid = plyr.Uid;
            }
            guid++;
            addForm = new AddPlayerForm(round, guid);
            addForm.FormClosed += new FormClosedEventHandler(AddForm_FormClosed);
            addForm.Show();
        }
        void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (addForm.actionType == "Accept")
            {
                int indexCount = 0;
                int buyindex = -1;
                foreach (Player plyr in tourny.PlayerList)
                {
                    if (plyr.Uid == 50)
                        buyindex = indexCount;
                    indexCount++;
                }
                bool buyPlayerRemoved = false;
                if (buyindex == -1)
                {
                    Player ByePlayer = new Player("BYE", "", "");
                    ByePlayer.Uid = 50;
                    tourny.PlayerList.Add(ByePlayer);
                    buyindex = tourny.PlayerList.Count - 1;
                }
                else
                {
                    tourny.PlayerList.Remove(tourny.PlayerList[buyindex]);
                    //tourny.RoundList[round].PairingList.Remove(tourny.RoundList[round].PairingList[index]);
                    buyPlayerRemoved = true;
                }
                tourny.PlayerList.Add(addForm.newPlayer);
                int newplayerIndex = tourny.PlayerList.Count - 1;

                bool roundStarted = false;
                foreach (Pairing p in tourny.RoundList[round].PairingList)
                {
                    if (p.Finished)
                        roundStarted = true;
                }
                DialogResult result = DialogResult.No;
                if (!roundStarted)
                    result = MessageBox.Show("Would You Like To Automatically Reassign Pairings? \nSelecting 'No' will allow you to edit pairings manually", "Pairing Resignment", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    if (buyPlayerRemoved == false)
                    {
                        Pairing pair = new Pairing();
                        pair.Player1 = tourny.PlayerList[newplayerIndex];
                        pair.Player2 = tourny.PlayerList[buyindex];
                        tourny.RoundList[round].PairingList.Add(pair);
                    }
                    else
                    {
                        foreach (Pairing p in tourny.RoundList[round].PairingList)
                        {
                            if (p.Player1.Uid == 50)
                                p.Player1 = tourny.PlayerList[newplayerIndex];
                            else if (p.Player2.Uid == 50)
                                p.Player2 = tourny.PlayerList[newplayerIndex];
                        }
                    }
                }
                else
                {
                    tourny.RoundList[round].PairingList.Clear();
                    tourny.RoundList[round].createPairings();
                }
                saveTournament();
                refreshDataGridView();
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
            for (int i = 0; i < pairingDataGridView.ColumnCount; i++)
            { pairingDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; }

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
                saveTournament();
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

        private void printButton_Click(object sender, EventArgs e)
        {
            row = 0;
            pvDialog.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int rowPosition = 25;

            // draw headers
            DrawHeader(e.Graphics, ref rowPosition);

            rowPosition += 40;

            // draw each row
            DrawGridBody(e.Graphics, rowPosition);

            // see if there are more pages to print
            if (((DataTable)pairingDataGridView.DataSource).Rows.Count > row)
                e.HasMorePages = true;
            else
                row = 0;
        }
        private void DrawHeader(Graphics g, ref int y_value)
        {
            int x_value = 175;
            Font bold = new Font(this.Font, FontStyle.Bold);

            foreach (DataGridViewColumn dc in pairingDataGridView.Columns)
            {
                if (dc.DisplayIndex != 3)
                {
                    g.DrawString(dc.HeaderText, bold, Brushes.Black, (float)x_value, (float)y_value);
                    x_value += dc.Width + 5;
                }
            }
        }
        private void DrawGridBody(Graphics g, int y_value)
        {
            int x_value;

            for (int i = 0; (i < NUM_ROWS_PER_PAGE) && ((i + row) < ((DataTable)pairingDataGridView.DataSource).Rows.Count); ++i)
            {
                DataRow dr = ((DataTable)pairingDataGridView.DataSource).Rows[i + row];
                x_value = 175;

                // draw a solid line
                g.DrawLine(Pens.Black, new Point(x_value, y_value), new Point(this.Width, y_value));

                foreach (DataGridViewColumn dc in pairingDataGridView.Columns)
                {
                    if (dc.DisplayIndex != 3)
                    {
                        string text = dr[dc.DataPropertyName].ToString();
                        g.DrawString(text, this.Font, Brushes.Black, (float)x_value, (float)y_value + 10f);
                        x_value += dc.Width + 5;
                    }
                }

                y_value += 40;
            }

            row += NUM_ROWS_PER_PAGE;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string complete = Path.Combine(systemPath, "DohTwo", tourny.Name + ".json");
                System.IO.FileInfo file = new System.IO.FileInfo(complete);
                file.Directory.Create(); // If the directory already exists, this method does nothing.
                File.WriteAllText(complete, JsonConvert.SerializeObject(tourny));
                MessageBox.Show("Tournament Saved", "Save");
            }
            catch
            {
                MessageBox.Show("Tournament Was Not Saved", "Error");

            }
        }
        private void saveTournament()
        {
            try
            {

                string systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string complete = Path.Combine(systemPath, "DohTwo", tourny.Name + ".json");
                System.IO.FileInfo file = new System.IO.FileInfo(complete);
                file.Directory.Create(); // If the directory already exists, this method does nothing.
                File.WriteAllText(complete, JsonConvert.SerializeObject(tourny));
            }
            catch
            {
                MessageBox.Show("Tournament Was Not Saved", "Error");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                int foundGuid = 0;
                int foundIndex = 0;
                for (int x = startSearch; x < tourny.PlayerList.Count; x++)
                {
                    string upperSearch = tourny.PlayerList[x].displayName.ToUpper();
                    if (upperSearch.Contains(searchTextBox.Text.ToUpper()))
                    {
                        foundGuid = tourny.PlayerList[x].Uid;
                        foundIndex = x;
                        startSearch = x + 1;
                        break;
                    }
                }
                if (foundGuid == 0)
                {
                    for (int x = 0; x < tourny.PlayerList.Count; x++)
                    {
                        string upperSearch = tourny.PlayerList[x].displayName.ToUpper();
                        if (upperSearch.Contains(searchTextBox.Text.ToUpper()))
                        {
                            foundGuid = tourny.PlayerList[x].Uid;
                            foundIndex = x;
                            startSearch = x + 1;
                            break;
                        }
                    }
                }
                if (foundGuid != 0)
                {
                    int rowIndex = 0;
                    foreach (Pairing pair in tourny.RoundList[round].PairingList)
                    {
                        if (pair.Player1.Uid == foundGuid)
                        {
                            pairingDataGridView.CurrentCell = pairingDataGridView.Rows[rowIndex].Cells[1];
                        }
                        else if (pair.Player2.Uid == foundGuid)
                        {
                            pairingDataGridView.CurrentCell = pairingDataGridView.Rows[rowIndex].Cells[2];
                        }
                        rowIndex++;
                    }
                }
            }
            //searchTextBox.Clear();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            startSearch = 0;
        }
        public void CreateMyMainMenu()
        {
            // Create an empty MainMenu.
            MainMenu mainMenu1 = new MainMenu();

            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();
            MenuItem menuItem3 = new MenuItem();
            MenuItem menuItem4 = new MenuItem();

            MenuItem menuItem5 = new MenuItem();
            MenuItem menuItem6 = new MenuItem();
            MenuItem menuItem7 = new MenuItem();
            MenuItem menuItem8 = new MenuItem();
            MenuItem menuItem9 = new MenuItem();
            MenuItem menuItem10 = new MenuItem();

            menuItem1.Text = "File";
            menuItem3.Text = "Save Tournament";
            //menuItem4.Text = "Load Tournment...";

            menuItem4.Text = "Player";
            menuItem7.Text = "Add Player";
            menuItem8.Text = "-";
            menuItem9.Text = "Swap Player";
            menuItem10.Text = "Drop Player";

            menuItem2.Text = "Help";
            menuItem5.Text = "Open Wiki";
            menuItem6.Text = "About";
            
            menuItem3.Click += new System.EventHandler(this.SaveButton_Click);
            // menuItem4.Click += new System.EventHandler(this.loadButton_Click);
            
            menuItem7.Click += new System.EventHandler(this.addPlayer_MenuItemClick);
            menuItem9.Click += new System.EventHandler(this.SwapPlayer_MenuItemClick);
            menuItem10.Click += new System.EventHandler(dropPlayer_MenuItemClick);
            menuItem5.Click += new System.EventHandler(this.viewWikiToolStripMenuItem_Click);
            menuItem6.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // Add two MenuItem objects to the MainMenu.
            mainMenu1.MenuItems.Add(menuItem1);
            mainMenu1.MenuItems.Add(menuItem4);
            mainMenu1.MenuItems.Add(menuItem2);
            mainMenu1.MenuItems[0].MenuItems.Add(menuItem3);
            //mainMenu1.MenuItems[0].MenuItems.Add(menuItem4);

            mainMenu1.MenuItems[1].MenuItems.Add(menuItem7);
            mainMenu1.MenuItems[1].MenuItems.Add(menuItem8);
            mainMenu1.MenuItems[1].MenuItems.Add(menuItem9);
            mainMenu1.MenuItems[1].MenuItems.Add(menuItem10);

            mainMenu1.MenuItems[2].MenuItems.Add(menuItem5);
            mainMenu1.MenuItems[2].MenuItems.Add(menuItem6);
            
            

            
            // Add functionality to the menu items using the Click event. 


            // Bind the MainMenu to Form1.
            Menu = mainMenu1;
        }
        private void viewWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/QuickenTheDead/TournamentTracker/wiki");
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abootform = new AboutForm();
            abootform.Show();
        }

        private void pairingDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void pairingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
