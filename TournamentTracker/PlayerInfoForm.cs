﻿/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TournamentTracker
{
	/// <summary>
	/// Description of PlayerInfoForm.
	/// </summary>
	public partial class PlayerInfoForm : Form
	{
		public Player player = new Player();
		public String Action = "Cancel";
		public PlayerInfoForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public PlayerInfoForm(Player player1)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			player = player1;
			firstNameTextBox.Text = player.firstName;
			lastNameTextBox.Text = player.lastName;
			factionComboBox.Text = player.faction;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AddButtonClick(object sender, EventArgs e)
		{
			if (firstNameTextBox.Text == "")
			{
				MessageBox.Show("Please Enter First Name", "Error Message");
			}
			else if (lastNameTextBox.Text == "")
			{
				MessageBox.Show("Please Enter Last Name", "Error Message");
			}
			else if (factionComboBox.Text=="")
			{
				MessageBox.Show("Please Select A Faction", "Error Message");
			}
			else
			{
				player.firstName = firstNameTextBox.Text;
				player.lastName = lastNameTextBox.Text;
				player.faction = factionComboBox.Text;
				Action = "Update";
				this.Close();
			}
		}
		void DeleteButtonClick(object sender, EventArgs e)
		{
			Action = "Delete";
			this.Close();
		}
		void CancelButtonClick(object sender, EventArgs e)
		{
			Action = "Cancel";
			this.Close();
		}
	}
}
