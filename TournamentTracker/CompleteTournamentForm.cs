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
        public CompleteTournamentForm()
        {
            InitializeComponent();
        }
        public CompleteTournamentForm(Tournament tournament)
        {
            tourny = tournament;
            InitializeComponent();
            calcSos();
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
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Player";
            foreach (Player Plyr in tourny.PlayerList)
            {

                richTextBox1.Text = richTextBox1.Text + ",\n" + Plyr.firstName + " " + Plyr.lastName;
            }
        }
    }
}
