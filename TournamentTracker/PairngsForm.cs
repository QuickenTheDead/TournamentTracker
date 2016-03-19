/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 15/03/2016
 * Time: 10:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TournamentTracker
{
	/// <summary>
	/// Description of PairngsForm.
	/// </summary>
	public partial class PairngsForm : Form
	{
        Tournament tourny;

        public PairngsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        public PairngsForm(List<Player> players)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            tourny = new Tournament(players);
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void PairngsFormLoad(object sender, EventArgs e)
		{
            foreach (Pairing pair in tourny.RoundList[0].PairingList)
            {
                testListBox.Items.Add(pair.Player1.displayName + " " + pair.Player2.displayName + " " + pair.Table);
            }
        }
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
