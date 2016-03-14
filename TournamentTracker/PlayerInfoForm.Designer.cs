/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 13/03/2016
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TournamentTracker
{
	partial class PlayerInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label factionLabel;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ComboBox factionComboBox;
		
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
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.factionLabel = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.factionComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.Location = new System.Drawing.Point(13, 13);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(100, 23);
			this.firstNameLabel.TabIndex = 0;
			this.firstNameLabel.Text = "First Name";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.Location = new System.Drawing.Point(13, 40);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(100, 23);
			this.lastNameLabel.TabIndex = 1;
			this.lastNameLabel.Text = "Last Name";
			// 
			// factionLabel
			// 
			this.factionLabel.Location = new System.Drawing.Point(13, 67);
			this.factionLabel.Name = "factionLabel";
			this.factionLabel.Size = new System.Drawing.Size(100, 23);
			this.factionLabel.TabIndex = 2;
			this.factionLabel.Text = "Faction";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(120, 13);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(137, 20);
			this.firstNameTextBox.TabIndex = 3;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(120, 40);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(137, 20);
			this.lastNameTextBox.TabIndex = 4;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(13, 94);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(100, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Add Player";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(120, 94);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(100, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// factionComboBox
			// 
			this.factionComboBox.FormattingEnabled = true;
			this.factionComboBox.Items.AddRange(new object[] {
			"Cygnar",
			"Khador",
			"Protectorate of Menoth",
			"Cryx",
			"Retribution of Scyrah",
			"Convergence of Cyriss",
			"Mercenaries",
			"Trollblood",
			"Circle Orboros",
			"Legion of Everblight",
			"Skorne",
			"Minions",
			"Other"});
			this.factionComboBox.Location = new System.Drawing.Point(120, 68);
			this.factionComboBox.Name = "factionComboBox";
			this.factionComboBox.Size = new System.Drawing.Size(137, 21);
			this.factionComboBox.TabIndex = 8;
			// 
			// PlayerInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 123);
			this.Controls.Add(this.factionComboBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.factionLabel);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Name = "PlayerInfoForm";
			this.Text = "PlayerInfoForm";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
