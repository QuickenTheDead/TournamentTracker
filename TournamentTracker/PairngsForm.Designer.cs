﻿/*
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
            this.previousRoundButton = new System.Windows.Forms.Button();
            this.nextRoundbutton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.roundgroupBox = new System.Windows.Forms.GroupBox();
            this.completeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pairingDataGridView)).BeginInit();
            this.roundgroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
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
            // previousRoundButton
            // 
            this.previousRoundButton.Location = new System.Drawing.Point(6, 19);
            this.previousRoundButton.Name = "previousRoundButton";
            this.previousRoundButton.Size = new System.Drawing.Size(75, 23);
            this.previousRoundButton.TabIndex = 2;
            this.previousRoundButton.Text = "Previous";
            this.previousRoundButton.UseVisualStyleBackColor = true;
            // 
            // nextRoundbutton
            // 
            this.nextRoundbutton.Location = new System.Drawing.Point(87, 19);
            this.nextRoundbutton.Name = "nextRoundbutton";
            this.nextRoundbutton.Size = new System.Drawing.Size(75, 23);
            this.nextRoundbutton.TabIndex = 3;
            this.nextRoundbutton.Text = "Next";
            this.nextRoundbutton.UseVisualStyleBackColor = true;
            this.nextRoundbutton.Click += new System.EventHandler(this.nextRoundbutton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(191, 267);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(88, 23);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print Pairings";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // roundgroupBox
            // 
            this.roundgroupBox.Controls.Add(this.previousRoundButton);
            this.roundgroupBox.Controls.Add(this.nextRoundbutton);
            this.roundgroupBox.Location = new System.Drawing.Point(12, 248);
            this.roundgroupBox.Name = "roundgroupBox";
            this.roundgroupBox.Size = new System.Drawing.Size(173, 48);
            this.roundgroupBox.TabIndex = 5;
            this.roundgroupBox.TabStop = false;
            this.roundgroupBox.Text = "Round";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(513, 267);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(124, 23);
            this.completeButton.TabIndex = 6;
            this.completeButton.Text = "Complete Tournament";
            this.completeButton.UseVisualStyleBackColor = true;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.textBox1);
            this.searchGroupBox.Location = new System.Drawing.Point(285, 248);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(222, 48);
            this.searchGroupBox.TabIndex = 7;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Players";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(141, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PairngsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 304);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.roundgroupBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.pairingDataGridView);
            this.Name = "PairngsForm";
            this.Text = "PairngsForm";
            this.Load += new System.EventHandler(this.PairngsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pairingDataGridView)).EndInit();
            this.roundgroupBox.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.DataGridView pairingDataGridView;
        private System.Windows.Forms.Button previousRoundButton;
        private System.Windows.Forms.Button nextRoundbutton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox roundgroupBox;
        private System.Windows.Forms.Button completeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
