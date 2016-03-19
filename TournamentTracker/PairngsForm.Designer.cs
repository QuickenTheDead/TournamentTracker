/*
 * Created by SharpDevelop.
 * User: cittah
 * Date: 15/03/2016
 * Time: 10:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TournamentTracker
{
	partial class PairngsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
            this.testListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // testListBox
            // 
            this.testListBox.FormattingEnabled = true;
            this.testListBox.Location = new System.Drawing.Point(13, 13);
            this.testListBox.Name = "testListBox";
            this.testListBox.Size = new System.Drawing.Size(365, 238);
            this.testListBox.TabIndex = 0;
            this.testListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pairListbox_MouseDoubleClick);
            // 
            // PairngsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 268);
            this.Controls.Add(this.testListBox);
            this.Name = "PairngsForm";
            this.Text = "PairngsForm";
            this.Load += new System.EventHandler(this.PairngsFormLoad);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.ListBox testListBox;
    }
}
