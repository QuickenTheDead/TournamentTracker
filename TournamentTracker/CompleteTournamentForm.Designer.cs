namespace TournamentTracker
{
    partial class CompleteTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 293);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(55, 312);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(94, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print Standings";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(176, 312);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(94, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export Players";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // CompleteTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 342);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CompleteTournamentForm";
            this.Text = "CompleteTournamentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exportButton;
    }
}