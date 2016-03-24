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
    public partial class TableForm : Form
    {
        public int tableNum;
        public string actionType = "Cancel";
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            actionType = "Accept";
            tableNum = Decimal.ToInt32(tableNumericUpDown.Value);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void tableNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableNumericUpDown_Enter(object sender, EventArgs e)
        {
            tableNumericUpDown.Select(0, 3);
        }
    }
}
