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
		int index;
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
          index = this.playersListbox.IndexFromPoint(e.Location);
         if (index != System.Windows.Forms.ListBox.NoMatches)
            {
         	  playerInfoForm = new PlayerInfoForm(playerList[index]);
              playerInfoForm.FormClosed += new FormClosedEventHandler(playerInfoForm_FormClosed);
			  playerInfoForm.Show();
              //MessageBox.Show(playerList[index].firstName);
            }
     	}
		void addPlayerClick(object sender, EventArgs e)
		{
			playerCount++;
			playerCountLabel.Text = "Player Count : " + (playerCount+1);
			playerList[playerCount] = new Player();
			
			//playerInfoForm.FormClosed += new FormClosedEventHandler(playerInfoForm_FormClosed);
			//playerInfoForm.Show();
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
				playerList[playerCount].firstName = firstNameTextBox.Text;
				playerList[playerCount].lastName = lastNameTextBox.Text;
				playerList[playerCount].faction = factionComboBox.Text;
				testLabel.Text = playerList[playerCount].firstName + " " + playerList[playerCount].lastName + " " + playerList[playerCount].faction;
				playersListbox.Items.Add(playerList[playerCount].firstName + " (" + playerList[playerCount].faction + ")");
				firstNameTextBox.Clear();
				lastNameTextBox.Clear();
				factionComboBox.SelectedIndex = 0;
				factionComboBox.SelectedItem = null;
				firstNameTextBox.Focus();
			}

		}
		void playerInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
			if (playerInfoForm.Action=="Delete")
			{
				for(int x=index; x<playerCount+1; x++)
				{
					if (x==playerCount)
					{
						playerList[x] = null;
					}
					else
					{
						playerList[x] = playerList[x+1];
					}
				}
				playerCount--;
				playersListbox.Items.Clear();
				for(int x=0; x<playerCount+1; x++)
				{
				  	playersListbox.Items.Add(playerList[x].firstName + " (" + playerList[x].faction + ")");
				}
				playerCountLabel.Text = "Player Count : " + (playerCount+1);
				
			}
			else if(playerInfoForm.Action=="Update")
			{
				
    			playerList[index] = playerInfoForm.player;
				testLabel.Text = playerList[index].firstName + " " + playerList[index].lastName + " " + playerList[index].faction;
				playersListbox.Items.Clear();
				for(int x=0; x<playerCount+1; x++)
				{
				  	playersListbox.Items.Add(playerList[x].firstName + " (" + playerList[x].faction + ")");

				}
				
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
			firstNameTextBox.Focus();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void LastNamelabelClick(object sender, EventArgs e)
		{
	
		}

	}
}
