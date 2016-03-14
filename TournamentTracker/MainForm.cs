/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 8:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TournamentTracker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Player [] playerList = new Player[128];
		public int playerCount = -1;
		public PlayerInfoForm playerInfoForm = new PlayerInfoForm();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void playerListbox_MouseDoubleClick(object sender, MouseEventArgs e)
    	{
         int index = this.playersListbox.IndexFromPoint(e.Location);
         if (index != System.Windows.Forms.ListBox.NoMatches)
            {
              MessageBox.Show(playerList[index].firstName);
            }
     	}
		void addPlayerClick(object sender, EventArgs e)
		{
			playerCount++;
			playerList[playerCount] = new Player();
			
			playerInfoForm.FormClosed += new FormClosedEventHandler(playerInfoForm_FormClosed);
			playerInfoForm.Show();
		}
		void playerInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (playerInfoForm.player.firstName =="noInfo" || playerInfoForm.player.lastName=="noInfo" || playerInfoForm.player.faction=="noInfo")
			{
				MessageBox.Show("Player not added");
			}
			else
			{
    			playerList[playerCount] = playerInfoForm.player;
				testLabel.Text = playerList[playerCount].firstName + " " + playerList[playerCount].lastName + " " + playerList[playerCount].faction;
				playersListbox.Items.Add(playerList[playerCount].firstName);
				
			}
			playerInfoForm = new PlayerInfoForm();
		}

	}
}
