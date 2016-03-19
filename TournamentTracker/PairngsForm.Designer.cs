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
            this.pairingDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pairingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pairingDataGridView
            // 
            this.pairingDataGridView.AllowUserToAddRows = false;
            this.pairingDataGridView.AllowUserToDeleteRows = false;
            this.pairingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pairingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pairingDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pairingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pairingDataGridView.MultiSelect = false;
            this.pairingDataGridView.Name = "pairingDataGridView";
            this.pairingDataGridView.ReadOnly = true;
            this.pairingDataGridView.Size = new System.Drawing.Size(649, 238);
            this.pairingDataGridView.TabIndex = 1;
            this.pairingDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pairDataGridView_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PairngsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 283);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pairingDataGridView);
            this.Name = "PairngsForm";
            this.Text = "PairngsForm";
            this.Load += new System.EventHandler(this.PairngsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pairingDataGridView)).EndInit();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.DataGridView pairingDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
