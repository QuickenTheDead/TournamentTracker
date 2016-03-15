/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 8:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
			this.addPlayerGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// addPlayerButton
			// 
			this.addPlayerButton.Location = new System.Drawing.Point(7, 111);
			this.addPlayerButton.Name = "addPlayerButton";
			this.addPlayerButton.Size = new System.Drawing.Size(95, 23);
			this.addPlayerButton.TabIndex = 11;
			this.addPlayerButton.Text = "Add Player";
			this.addPlayerButton.UseVisualStyleBackColor = true;
			this.addPlayerButton.Click += new System.EventHandler(this.addPlayerClick);
			// 
			// playersListbox
			// 
			this.playersListbox.FormattingEnabled = true;
			this.playersListbox.Location = new System.Drawing.Point(12, 12);
			this.playersListbox.Name = "playersListbox";
			this.playersListbox.Size = new System.Drawing.Size(254, 238);
			this.playersListbox.TabIndex = 1;
			this.playersListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerListbox_MouseDoubleClick);
			// 
			// testLabel
			// 
			this.testLabel.Location = new System.Drawing.Point(12, 275);
			this.testLabel.Name = "testLabel";
			this.testLabel.Size = new System.Drawing.Size(273, 23);
			this.testLabel.TabIndex = 2;
			this.testLabel.Text = "Test";
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
			this.addPlayerGroupBox.Location = new System.Drawing.Point(336, 12);
			this.addPlayerGroupBox.Name = "addPlayerGroupBox";
			this.addPlayerGroupBox.Size = new System.Drawing.Size(200, 143);
			this.addPlayerGroupBox.TabIndex = 3;
			this.addPlayerGroupBox.TabStop = false;
			this.addPlayerGroupBox.Text = "Add Player";
			// 
			// factionComboBox
			// 
			this.factionComboBox.FormattingEnabled = true;
			this.factionComboBox.Items.AddRange(new object[] {
			"Cygnar",
			"Khador",
			"Protectorate Of Menoth",
			"Cryx",
			"Retribution of Scyra",
			"Convergence of Cryss",
			"Mercinaries",
			"Trollbloods",
			"Circle Orboros",
			"Skorne",
			"Legion of Everblight",
			"Minions",
			"Other"});
			this.factionComboBox.Location = new System.Drawing.Point(73, 74);
			this.factionComboBox.Name = "factionComboBox";
			this.factionComboBox.Size = new System.Drawing.Size(121, 21);
			this.factionComboBox.TabIndex = 10;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(73, 47);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(121, 20);
			this.lastNameTextBox.TabIndex = 9;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(73, 20);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
			this.firstNameTextBox.TabIndex = 8;
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
			this.clearButton.Location = new System.Drawing.Point(107, 111);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(87, 23);
			this.clearButton.TabIndex = 12;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(424, 174);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(112, 23);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "Start Tournament";
			this.startButton.UseVisualStyleBackColor = true;
			// 
			// playerCountLabel
			// 
			this.playerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerCountLabel.Location = new System.Drawing.Point(302, 177);
			this.playerCountLabel.Name = "playerCountLabel";
			this.playerCountLabel.Size = new System.Drawing.Size(116, 23);
			this.playerCountLabel.TabIndex = 5;
			this.playerCountLabel.Text = "Player Count : 0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 307);
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

		}
	}
}
