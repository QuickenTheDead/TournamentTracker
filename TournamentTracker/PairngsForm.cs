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
        public PairngsForm(List<Player> players)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            tourny = new Tournament(players);
            columns.Add("Table");
            columns.Add("Player1");
            columns.Add("Player2");
            columns.Add("Complete");
            refreshDataGridView();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void PairngsFormLoad(object sender, EventArgs e)
		{
            
        }
        void resultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (resultsForm.actionType != "Cancel")
            {
                if (resultsForm.thisPair.WinningPlayer == 1)
                {
                    MessageBox.Show(tourny.RoundList[0].PairingList[index].Player1.firstName + " " + tourny.RoundList[0].PairingList[index].Player1.lastName + " WINS!", "Winning Message");
                }
                else
                {
                    MessageBox.Show(tourny.RoundList[0].PairingList[index].Player2.firstName + " " + tourny.RoundList[0].PairingList[index].Player2.lastName + " WINS!", "Winning Message");

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
                resultsForm = new ResultsRecorderForm(tourny.RoundList[0].PairingList[index]);
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
                foreach (Pairing pair in tourny.RoundList[0].PairingList)
                {
                    DataRow row = d.NewRow();
                    row["Table"] = pair.Table;
                    row["Player1"] = pair.Player1.displayName;
                    row["Player2"] = pair.Player2.displayName;
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
            int index = 0;
            foreach (DataGridViewRow row in pairingDataGridView.Rows)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                if(tourny.RoundList[0].PairingList[index].Finished == false)
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
    }
}
