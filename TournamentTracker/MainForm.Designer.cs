/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 8:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TournamentTracker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button addPlayerButton;
		private System.Windows.Forms.ListBox playersListbox;
		private System.Windows.Forms.Label testLabel;
		private System.Windows.Forms.GroupBox addPlayerGroupBox;
		private System.Windows.Forms.ComboBox factionComboBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label Factionlabel;
		private System.Windows.Forms.Label LastNamelabel;
		private System.Windows.Forms.Label FirstNamelabel;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label playerCountLabel;
		private System.Windows.Forms.Label playerListLabel;
		private System.Windows.Forms.Label tablesLabel;
		private System.Windows.Forms.Label roundslabel;
		private System.Windows.Forms.Button clearPlayersButton;

		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		void InitializeComponent()
		{
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListbox = new System.Windows.Forms.ListBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.addPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.factionComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.Factionlabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerCountLabel = new System.Windows.Forms.Label();
            this.playerListLabel = new System.Windows.Forms.Label();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.roundslabel = new System.Windows.Forms.Label();
            this.clearPlayersButton = new System.Windows.Forms.Button();
            this.tournNamelabel = new System.Windows.Forms.Label();
            this.tournNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(7, 111);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(95, 23);
            this.addPlayerButton.TabIndex = 8;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerClick);
            // 
            // playersListbox
            // 
            this.playersListbox.FormattingEnabled = true;
            this.playersListbox.Location = new System.Drawing.Point(12, 38);
            this.playersListbox.Name = "playersListbox";
            this.playersListbox.Size = new System.Drawing.Size(254, 277);
            this.playersListbox.TabIndex = 2;
            this.playersListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerListbox_MouseDoubleClick);
            // 
            // testLabel
            // 
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(297, 262);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(155, 23);
            this.testLabel.TabIndex = 16;
            this.testLabel.Text = "Test Label";
            // 
            // addPlayerGroupBox
            // 
            this.addPlayerGroupBox.Controls.Add(this.factionComboBox);
            this.addPlayerGroupBox.Controls.Add(this.lastNameTextBox);
            this.addPlayerGroupBox.Controls.Add(this.firstNameTextBox);
            this.addPlayerGroupBox.Controls.Add(this.Factionlabel);
            this.addPlayerGroupBox.Controls.Add(this.LastNamelabel);
            this.addPlayerGroupBox.Controls.Add(this.FirstNamelabel);
            this.addPlayerGroupBox.Controls.Add(this.clearButton);
            this.addPlayerGroupBox.Controls.Add(this.addPlayerButton);
            this.addPlayerGroupBox.Location = new System.Drawing.Point(289, 38);
            this.addPlayerGroupBox.Name = "addPlayerGroupBox";
            this.addPlayerGroupBox.Size = new System.Drawing.Size(200, 143);
            this.addPlayerGroupBox.TabIndex = 5;
            this.addPlayerGroupBox.TabStop = false;
            this.addPlayerGroupBox.Text = "Add Player";
            // 
            // factionComboBox
            // 
            this.factionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.factionComboBox.FormattingEnabled = true;
            this.factionComboBox.Items.AddRange(new object[] {
            "Cygnar",
            "Khador",
            "Protectorate Of Menoth",
            "Cryx",
            "Retribution of Scyra",
            "Convergence of Cryss",
            "Mercenaries",
            "Trollbloods",
            "Circle Orboros",
            "Skorne",
            "Legion of Everblight",
            "Minions",
            "Other"});
            this.factionComboBox.Location = new System.Drawing.Point(73, 74);
            this.factionComboBox.Name = "factionComboBox";
            this.factionComboBox.Size = new System.Drawing.Size(121, 21);
            this.factionComboBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 47);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(73, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // Factionlabel
            // 
            this.Factionlabel.Location = new System.Drawing.Point(8, 74);
            this.Factionlabel.Name = "Factionlabel";
            this.Factionlabel.Size = new System.Drawing.Size(59, 23);
            this.Factionlabel.TabIndex = 7;
            this.Factionlabel.Text = "Faction";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.Location = new System.Drawing.Point(8, 47);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(59, 23);
            this.LastNamelabel.TabIndex = 6;
            this.LastNamelabel.Text = "Last Name";
            this.LastNamelabel.Click += new System.EventHandler(this.LastNamelabelClick);
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(8, 20);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(59, 23);
            this.FirstNamelabel.TabIndex = 5;
            this.FirstNamelabel.Text = "First Name";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(107, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(288, 288);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start Tournament";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // playerCountLabel
            // 
            this.playerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountLabel.Location = new System.Drawing.Point(297, 193);
            this.playerCountLabel.Name = "playerCountLabel";
            this.playerCountLabel.Size = new System.Drawing.Size(116, 23);
            this.playerCountLabel.TabIndex = 13;
            this.playerCountLabel.Text = "Player Count : 0";
            // 
            // playerListLabel
            // 
            this.playerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListLabel.Location = new System.Drawing.Point(13, 12);
            this.playerListLabel.Name = "playerListLabel";
            this.playerListLabel.Size = new System.Drawing.Size(100, 23);
            this.playerListLabel.TabIndex = 1;
            this.playerListLabel.Text = "Player List";
            // 
            // tablesLabel
            // 
            this.tablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesLabel.Location = new System.Drawing.Point(297, 216);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(116, 23);
            this.tablesLabel.TabIndex = 14;
            this.tablesLabel.Text = "Tables : 0";
            // 
            // roundslabel
            // 
            this.roundslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundslabel.Location = new System.Drawing.Point(297, 239);
            this.roundslabel.Name = "roundslabel";
            this.roundslabel.Size = new System.Drawing.Size(116, 23);
            this.roundslabel.TabIndex = 15;
            this.roundslabel.Text = "Max Rounds : 0";
            // 
            // clearPlayersButton
            // 
            this.clearPlayersButton.Location = new System.Drawing.Point(396, 288);
            this.clearPlayersButton.Name = "clearPlayersButton";
            this.clearPlayersButton.Size = new System.Drawing.Size(98, 23);
            this.clearPlayersButton.TabIndex = 11;
            this.clearPlayersButton.Text = "Clear Players";
            this.clearPlayersButton.UseVisualStyleBackColor = true;
            this.clearPlayersButton.Click += new System.EventHandler(this.ClearPlayersButtonClick);
            // 
            // tournNamelabel
            // 
            this.tournNamelabel.AutoSize = true;
            this.tournNamelabel.Location = new System.Drawing.Point(286, 12);
            this.tournNamelabel.Name = "tournNamelabel";
            this.tournNamelabel.Size = new System.Drawing.Size(95, 13);
            this.tournNamelabel.TabIndex = 3;
            this.tournNamelabel.Text = "Tournament Name";
            // 
            // tournNameTextBox
            // 
            this.tournNameTextBox.Location = new System.Drawing.Point(387, 9);
            this.tournNameTextBox.Name = "tournNameTextBox";
            this.tournNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.tournNameTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.addPlayerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(522, 325);
            this.Controls.Add(this.tournNameTextBox);
            this.Controls.Add(this.tournNamelabel);
            this.Controls.Add(this.clearPlayersButton);
            this.Controls.Add(this.roundslabel);
            this.Controls.Add(this.tablesLabel);
            this.Controls.Add(this.playerListLabel);
            this.Controls.Add(this.playerCountLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addPlayerGroupBox);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.playersListbox);
            this.Name = "MainForm";
            this.Text = "TournamentTracker";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.addPlayerGroupBox.ResumeLayout(false);
            this.addPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label tournNamelabel;
        private System.Windows.Forms.TextBox tournNameTextBox;
    }
}
