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
        List<string> columns = new List<string>();
        int round= 0;
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
                if (resultsForm.thisPair.WinningPlayer == 1)
                {
                    //MessageBox.Show(tourny.RoundList[round].PairingList[index].Player1.firstName + " " + tourny.RoundList[round].PairingList[index].Player1.lastName + " WINS!", "Winning Message");
                    tourny.PlayerList[oneIndex].Wins++;
                }
                else
                {
                    //MessageBox.Show(tourny.RoundList[round].PairingList[index].Player2.firstName + " " + tourny.RoundList[round].PairingList[index].Player2.lastName + " WINS!", "Winning Message");
                    tourny.PlayerList[twoIndex].Wins++;
                }
                tourny.PlayerList[oneIndex].ArmyPointsDestroyed += resultsForm.thisPair.OnePlayerAP;
                tourny.PlayerList[oneIndex].ControlPoints += resultsForm.thisPair.OnePlayerCP;
                tourny.PlayerList[oneIndex].oppGuids.Add(tourny.PlayerList[twoIndex].Uid);
                tourny.PlayerList[twoIndex].oppGuids.Add(tourny.PlayerList[oneIndex].Uid);
                tourny.PlayerList[twoIndex].ArmyPointsDestroyed += resultsForm.thisPair.TwoPlayerAP;
                tourny.PlayerList[twoIndex].ControlPoints += resultsForm.thisPair.TwoPlayerCP;
                bool roundFinished = false;
                foreach(Pairing pair in tourny.RoundList[round].PairingList)
                {
                    if(pair.Finished == false)
                    {
                        roundFinished = true;
                    }
                }
                if(roundFinished)
                {
                    nextRoundbutton.Enabled = true;
                }
                refreshDataGridView();
            }

        }
        private void pairDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            if (e.ColumnIndex == 3)
            {
                index = e.RowIndex;
                resultsForm = new ResultsRecorderForm(tourny.RoundList[round].PairingList[index]);
                resultsForm.FormClosed += new FormClosedEventHandler(resultsForm_FormClosed);
                resultsForm.Show();
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
            round++;
            if (tourny.RoundList.Count < round+1)
            {
                Round newRound = new Round(tourny.PlayerList, round);
                newRound.createPairings();
                tourny.RoundList.Add(newRound);
                
            }
            previousRoundButton.Enabled = true;
            refreshDataGridView();
            roundgroupBox.Text = "Round " + (round + 1);
        }

        private void previousRoundButton_Click(object sender, EventArgs e)
        {
            round--;
            if (round == 0)
                previousRoundButton.Enabled = false;
            roundgroupBox.Text = "Round " + (round + 1);
            refreshDataGridView();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            CompleteTournamentForm complete = new CompleteTournamentForm(tourny);
            complete.Show();
        }
    }
}
