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
    public partial class ResultsRecorderForm : Form
    {
        public string actionType = "Cancel";
        public int winningplayer;
        public int oneCP;
        public int twoCP;
        public int oneAP;
        public int twoAP;
        public ResultsRecorderForm()
        {
            InitializeComponent();
            
        }
        public ResultsRecorderForm(Pairing pair)
        {
          
            InitializeComponent();
            PlayerOneLabel.Text = pair.Player1.displayName;
            playerTwoLabel.Text = pair.Player2.displayName;
            oneCPnumericUpDown.Value = pair.OnePlayerCP;
            oneArmynumericUpDown.Value = pair.OnePlayerAP;
            twoCPnumericUpDown.Value = pair.TwoPlayerCP;
            twoArmynumericUpDown.Value = pair.TwoPlayerAP;
            if (pair.WinningPlayer == 0 || pair.WinningPlayer == 1)
            {
                oneWinnerRadioButton.Checked = true;
            }
            else
            {
                twoWinnerRadioButton.Checked = true;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            actionType = "Accept";
            if (oneWinnerRadioButton.Checked)
            {
                winningplayer = 1;
            }
            else
            {
                winningplayer = 2;
            }
            oneCP = Decimal.ToInt32(oneCPnumericUpDown.Value);
            oneAP = Decimal.ToInt32(oneArmynumericUpDown.Value);
            twoCP = Decimal.ToInt32(twoCPnumericUpDown.Value);
            twoAP = Decimal.ToInt32(twoArmynumericUpDown.Value);
           // thisPair.Finished = true;
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultsRecorderForm_Load(object sender, EventArgs e)
        {

        }

        private void oneCPnumericUpDown_Enter(object sender, EventArgs e)
        {
            oneCPnumericUpDown.Select(0, 3);
        }

        private void twoCPnumericUpDown_Enter(object sender, EventArgs e)
        {
            twoCPnumericUpDown.Select(0, 3);
        }

        private void oneArmynumericUpDown_Enter(object sender, EventArgs e)
        {
            oneArmynumericUpDown.Select(0, 3);
        }

        private void twoArmynumericUpDown_Enter(object sender, EventArgs e)
        {
            twoArmynumericUpDown.Select(0, 3);
        }
    }
}
