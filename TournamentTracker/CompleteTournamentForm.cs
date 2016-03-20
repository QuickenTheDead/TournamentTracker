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
            richTextBox1.Text = "FirstName,LastName,Faction,Wins,Sos,CP,APD";
            foreach(Player Plyr in tourny.PlayerList)
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + Plyr.firstName + "," + Plyr.lastName + "," + Plyr.faction + "," + Plyr.Wins + "," + Plyr.SOS + "," + Plyr.ControlPoints + "," + Plyr.ArmyPointsDestroyed;
            }
        }
    }
}
