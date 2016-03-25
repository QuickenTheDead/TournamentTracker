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
    public partial class dropSwapForm : Form
    {
        public string actionType = "Cancel";
        public Player player;
        public int playernumber;
        public dropSwapForm()
        {
            InitializeComponent();
        }
        public dropSwapForm(Player plyr, int playerNum)
        {
            InitializeComponent();
            player = plyr;
            playernumber = playerNum;
            nameLabel.Text = plyr.displayName;

        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to drop " + player.displayName + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                actionType = "Drop";
                Close();
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            actionType = "Swap";
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            actionType = "Cancel";
            Close();
        }
    }
}
