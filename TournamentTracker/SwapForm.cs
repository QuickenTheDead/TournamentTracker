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
    public partial class SwapForm : Form
    {
        public List<Player> lstPlayers = new List<Player>();
        public Player swapPlayer;
        public string actionType = "Cancel";
        public Player selectedPlayer;
        public SwapForm()
        {
            InitializeComponent();
        }
        public SwapForm(List<Player> list, Player swapPlyr)
        {
            InitializeComponent();
            lstPlayers = list;
            swapPlayer = swapPlyr;
            PlayerComboBox.DataSource = lstPlayers;
            PlayerComboBox.DisplayMember = "displayName";
            nameLabel.Text = swapPlyr.displayName;
        }


        private void SwapForm_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            actionType = "Accept";
            selectedPlayer = lstPlayers[PlayerComboBox.SelectedIndex];
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            actionType = "Cancel";
            Close();
        }
    }
}
