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
        public Pairing thisPair;
        public string actionType = "Cancel";
        public ResultsRecorderForm()
        {
            InitializeComponent();
            
        }
        public ResultsRecorderForm(Pairing pair)
        {
            thisPair = pair;
            InitializeComponent();
            PlayerOneLabel.Text = pair.Player1.displayName;
            playerTwoLabel.Text = pair.Player2.displayName;
            oneWinnerRadioButton.Checked = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            actionType = "Accept";
            if (oneWinnerRadioButton.Checked)
            {
                thisPair.WinningPlayer = 1;
            }
            else
            {
                thisPair.WinningPlayer = 2;
            }
            thisPair.OnePlayerCP = Decimal.ToInt32(oneCPnumericUpDown.Value);
            thisPair.OnePlayerAP = Decimal.ToInt32(oneArmynumericUpDown.Value);
            thisPair.TwoPlayerCP = Decimal.ToInt32(twoCPnumericUpDown.Value);
            thisPair.TwoPlayerAP = Decimal.ToInt32(twoArmynumericUpDown.Value);
            thisPair.Finished = true;
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
