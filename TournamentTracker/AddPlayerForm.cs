using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTracker
{
    public partial class AddPlayerForm : Form
    {
        int roundNum;
        int guid;
        public string actionType = "Cancel";
        public Player newPlayer;
        public AddPlayerForm()
        {
            InitializeComponent();
        }
        public AddPlayerForm(int round, int UID)
        {
            InitializeComponent();
            roundNum = round + 1;
            winsNumericUpDown.Maximum = roundNum;
            CPNumericUpDown.Maximum = roundNum * 5;
            APDNumericUpDown.Maximum = roundNum * 100;
            guid = UID;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            actionType = "Accept";
            newPlayer = new Player(firstNameTextBox.Text, lastNameTextBox.Text, factionComboBox.Text);
            newPlayer.Uid = guid;
            newPlayer.Wins = Decimal.ToInt32(winsNumericUpDown.Value);
            newPlayer.ControlPoints = Decimal.ToInt32(CPNumericUpDown.Value);
            newPlayer.ArmyPointsDestroyed = Decimal.ToInt32(APDNumericUpDown.Value);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
