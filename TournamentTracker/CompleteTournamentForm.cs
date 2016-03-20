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
                foreach(int guid in player.oppGuids)
                { 
                    int index = tourny.PlayerList.FindIndex(x => x.Uid.Equals(guid));
                    player.SOS += tourny.PlayerList[index].Wins;
                }
                
            }
            tourny.PlayerList.Sort();
            standings();
        }
        private void standings()
        {
            richTextBox1.Text = String.Format("{0,-15},{1,-15},{2,-22},{3,1},{4,3},{5,3},{6,3}",
                                    "First Name",
                                    "Last Name",
                                    "Faction",
                                    "W",
                                    "SOS",
                                    "CPs",
                                    "APD");
            foreach (Player Plyr in tourny.PlayerList)
            {

                richTextBox1.Text = String.Format(richTextBox1.Text + "\n{0,-15},{1,-15},{2,-22},{3,1},{4,3},{5,3},{6,3}",
                                    Plyr.firstName,
                                    Plyr.lastName,
                                    Plyr.faction,
                                    Plyr.Wins,
                                    Plyr.SOS,
                                    Plyr.ControlPoints,
                                    Plyr.ArmyPointsDestroyed);
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
