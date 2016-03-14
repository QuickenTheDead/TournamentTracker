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
			this.addPlayerButton = new System.Windows.Forms.Button();
			this.playersListbox = new System.Windows.Forms.ListBox();
			this.testLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addPlayerButton
			// 
			this.addPlayerButton.Location = new System.Drawing.Point(80, 248);
			this.addPlayerButton.Name = "addPlayerButton";
			this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.addPlayerButton.TabIndex = 0;
			this.addPlayerButton.Text = "Add Player";
			this.addPlayerButton.UseVisualStyleBackColor = true;
			this.addPlayerButton.Click += new System.EventHandler(this.addPlayerClick);
			// 
			// playersListbox
			// 
			this.playersListbox.FormattingEnabled = true;
			this.playersListbox.Location = new System.Drawing.Point(80, 48);
			this.playersListbox.Name = "playersListbox";
			this.playersListbox.Size = new System.Drawing.Size(284, 108);
			this.playersListbox.TabIndex = 1;
			this.playersListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerListbox_MouseDoubleClick);
			// 
			// testLabel
			// 
			this.testLabel.Location = new System.Drawing.Point(80, 198);
			this.testLabel.Name = "testLabel";
			this.testLabel.Size = new System.Drawing.Size(273, 23);
			this.testLabel.TabIndex = 2;
			this.testLabel.Text = "Test";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 342);
			this.Controls.Add(this.testLabel);
			this.Controls.Add(this.playersListbox);
			this.Controls.Add(this.addPlayerButton);
			this.Name = "MainForm";
			this.Text = "TournamentTracker";
			this.ResumeLayout(false);

		}
	}
}
