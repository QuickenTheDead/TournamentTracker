using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TournamentTracker
{
   
    public partial class CompleteTournamentForm : Form
    {
        Tournament tourny;
        int row = 0;
        int NUM_ROWS_PER_PAGE = 20;
        public CompleteTournamentForm()
        {
            InitializeComponent();
        }
        public CompleteTournamentForm(Tournament tournament)
        {
            tourny = tournament;
            InitializeComponent();
            calcSos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetResultsTable();
            dataGridView1.Visible = true;
            dataGridView1.Columns[4].Width = 50;
            //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 50;

        }

        private void calcSos()
        {
            
            foreach(Player player in tourny.PlayerList)
            {
                player.SOS = 0;
                foreach(int guid in player.oppGuids)
                {
                    if (guid != 50)
                    {
                        int index = tourny.PlayerList.FindIndex(x => x.Uid.Equals(guid));
                        player.SOS += tourny.PlayerList[index].Wins;
                    }
                }
                
            }
            tourny.PlayerList.Sort();
            standings();
        }
        private void standings()
        {
            richTextBox1.Text = String.Format("{0,-3},{1,-15},{2,-15},{3,-22},{4,1},{5,3},{6,3},{7,3}",
                                    "#",
                                    "First Name",
                                    "Last Name",
                                    "Faction",
                                    "W",
                                    "SOS",
                                    "CPs",
                                    "APD");
            int rank = 0;
            foreach (Player Plyr in tourny.PlayerList)
            {
                rank++;
                if (Plyr.Uid != 50)
                {
                    string fName = Plyr.firstName.PadRight(15,' ');
                    string lName = Plyr.lastName.PadRight(15, ' ');
                    richTextBox1.Text = String.Format(richTextBox1.Text + "\n{0,-3},{1,-15},{2,-15},{3,-22},{4,1},{5,3},{6,3},{7,3}",
                                        rank,
                                        fName.Substring(0,15),
                                        lName.Substring(0,15),
                                        Plyr.faction,
                                        Plyr.Wins,
                                        Plyr.SOS,
                                        Plyr.ControlPoints,
                                        Plyr.ArmyPointsDestroyed);
                }
            }
        }

        private void standingButton_Click(object sender, EventArgs e)
        {
            standings();
            dataGridView1.Visible = true;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Player";
            foreach (Player Plyr in tourny.PlayerList)
            {

                richTextBox1.Text = richTextBox1.Text + ",\n" + Plyr.firstName + " " + Plyr.lastName;
            }
            dataGridView1.Visible = false;
        }
        public DataTable GetResultsTable()
        {
            // Create the output table.
            DataTable d = new DataTable();
                      
            // Add the program name to our columns.
            d.Columns.Add("Rank");
            d.Columns.Add("First Name");
            d.Columns.Add("Last Name");
            d.Columns.Add("Faction");
            d.Columns.Add("W");
            d.Columns.Add("SOS");
            d.Columns.Add("CPs");
            d.Columns.Add("APD");
            int rank = 0;
            // Put every column's numbers in this List.
            tourny.PlayerList.Sort();
            foreach (Player Plyr in tourny.PlayerList)
            {
                
                if (Plyr.Uid != 50)
                {
                    rank++;
                    DataRow row = d.NewRow();
                    string fName = Plyr.firstName.PadRight(15, ' ');
                    string lName = Plyr.lastName.PadRight(15, ' ');
                    row["Rank"] = rank;
                    row["First Name"] = fName.Substring(0, 15);
                    row["Last Name"] = lName.Substring(0, 15);
                    row["Faction"] = Plyr.faction;
                    row["W"] = Plyr.Wins;
                    row["SOS"] = Plyr.SOS;
                    row["CPs"] = Plyr.ControlPoints;
                    row["APD"] = Plyr.ArmyPointsDestroyed;
                    d.Rows.Add(row);

                }
            }
            return d;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            row = 0;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int rowPosition = 25;
            DrawTitle(e.Graphics, ref rowPosition);
            rowPosition += 50;
            // draw headers
            DrawHeader(e.Graphics, ref rowPosition);

            rowPosition += 40;

            // draw each row
            DrawGridBody(e.Graphics, rowPosition);

            // see if there are more pages to print
            if (((DataTable)dataGridView1.DataSource).Rows.Count > row)
                e.HasMorePages = true;
            else
                row = 0;
        }
        private void DrawHeader(Graphics g, ref int y_value)
        {
            int x_value = 20;
            Font bold = new Font(this.Font, FontStyle.Bold);

            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                
                    g.DrawString(dc.HeaderText, bold, Brushes.Black, (float)x_value, (float)y_value);
                if(dc.Index == 3)
                    x_value += dc.Width + 30;
                else
                    x_value += dc.Width + 5;
                
            }
        }
        private void DrawTitle(Graphics g, ref int y_value)
        {
            int x_value = 20;
            Font bold = new Font(this.Font, FontStyle.Bold);

            using (Font bigFont = new Font(SystemFonts.DefaultFont.FontFamily, 14, FontStyle.Bold))
            {
               // SizeF size = g.MeasureString(tourny.Name, bigFont, 20);
                g.DrawString(tourny.Name + " Standings", bigFont, Brushes.Black, (float)x_value, (float)y_value);
            }

            //g.DrawString(tourny.Name, bold, Brushes.Black, (float)x_value, (float)y_value);
        }
        private void DrawGridBody(Graphics g, int y_value)
        {
            int x_value;

            for (int i = 0; (i < NUM_ROWS_PER_PAGE) && ((i + row) < ((DataTable)dataGridView1.DataSource).Rows.Count); ++i)
            {
                DataRow dr = ((DataTable)dataGridView1.DataSource).Rows[i + row];
                x_value = 20;

                // draw a solid line
                g.DrawLine(Pens.Black, new Point(x_value, y_value), new Point(835, y_value));

                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    
                        string text = dr[dc.DataPropertyName].ToString();
                        g.DrawString(text, this.Font, Brushes.Black, (float)x_value, (float)y_value + 10f);
                        if (dc.Index == 3)
                            x_value += dc.Width + 30;
                        else
                            x_value += dc.Width + 5;

                }

                y_value += 40;
            }

            row += NUM_ROWS_PER_PAGE;
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            standings();
            dataGridView1.Visible = false;
        }
    }
}
