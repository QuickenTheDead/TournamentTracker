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
		public List<Player> lstPlayer = new List<Player>();
		public PlayerInfoForm playerInfoForm = new PlayerInfoForm();
        public PairngsForm pairform = new PairngsForm();
        int index;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			playersListbox.DataSource= lstPlayer;
			playersListbox.DisplayMember="displayName";

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void playerListbox_MouseDoubleClick(object sender, MouseEventArgs e)
    	{
          index = this.playersListbox.IndexFromPoint(e.Location);
          if (index != System.Windows.Forms.ListBox.NoMatches)
            {
         	  playerInfoForm = new PlayerInfoForm(lstPlayer[index]);
              playerInfoForm.FormClosed += new FormClosedEventHandler(playerInfoForm_FormClosed);
			  playerInfoForm.Show();
            }
     	}
		void addPlayerClick(object sender, EventArgs e)
		{
			if(firstNameTextBox.Text == "")
			{
				MessageBox.Show("Please Enter a First Name","Error Message");
			}
			else if (lastNameTextBox.Text == "")
			{
				MessageBox.Show("Please Enter a Last Name","Error Message");
			}
			else if (factionComboBox.Text == "")
			{
				MessageBox.Show("Please Select a Faction","Error Message");
			}
			else
			{
				
				Player newPlayer = new Player(firstNameTextBox.Text,lastNameTextBox.Text,factionComboBox.Text);
				
				testLabel.Text = newPlayer.firstName + " " + newPlayer.lastName + " " + newPlayer.faction;
				lstPlayer.Add(newPlayer);
				
				playersListbox.DataSource= null;
				playersListbox.DataSource= lstPlayer;
				playersListbox.DisplayMember="displayName";
				
				firstNameTextBox.Clear();
				lastNameTextBox.Clear();
				factionComboBox.SelectedIndex = 0;
				factionComboBox.SelectedItem = null;
				playerCountLabel.Text = "Player Count : " + lstPlayer.Count;
				firstNameTextBox.Focus();
			}

		}
		void playerInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
			if (playerInfoForm.Action=="Delete")
			{
				lstPlayer.Remove(lstPlayer[index]);
				
				playersListbox.DataSource= null;
				playersListbox.DataSource= lstPlayer;
				playersListbox.DisplayMember="displayName";
				playerCountLabel.Text = "Player Count : " + lstPlayer.Count;
				
			}
			else if(playerInfoForm.Action=="Update")
			{
				lstPlayer[index] = playerInfoForm.player;
				testLabel.Text = lstPlayer[index].firstName + " " + lstPlayer[index].lastName + " " + lstPlayer[index].faction;
			
				playersListbox.DataSource= null;
				playersListbox.DataSource= lstPlayer;
				playersListbox.DisplayMember="displayName";
				
			}
			playerInfoForm = new PlayerInfoForm();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			
				firstNameTextBox.Clear();
				lastNameTextBox.Clear();
				factionComboBox.SelectedIndex = 0;
				factionComboBox.SelectedItem = null;
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
				
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void LastNamelabelClick(object sender, EventArgs e)
		{
	
		}
		void ClearPlayersButtonClick(object sender, EventArgs e)
		{	
			DialogResult result1 = MessageBox.Show("Are you sure you want to clear all players?","Clear all Players?",MessageBoxButtons.YesNo);
			if(result1 == DialogResult.Yes)
			{			
				lstPlayer.Clear();
				playerCountLabel.Text = "Player Count : " + lstPlayer.Count;
	
				playersListbox.DataSource= null;
				playersListbox.DataSource= lstPlayer;
				playersListbox.DisplayMember="displayName";
			}
		}
		void StartButtonClick(object sender, EventArgs e)
		{
            if (IsOdd(lstPlayer.Count))
            {
                Player ByePlayer = new Player("BYE", "", "");
                lstPlayer.Add(ByePlayer);
            }
            pairform = new PairngsForm(lstPlayer);
            pairform.Show();
		}
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
