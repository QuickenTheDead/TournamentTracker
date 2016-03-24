namespace TournamentTracker
{
    partial class ResultsRecorderForm
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
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.oneWinnerRadioButton = new System.Windows.Forms.RadioButton();
            this.twoWinnerRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oneArmynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.oneCPnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.twoCPnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.twoArmynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneArmynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCPnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoCPnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoArmynumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerOneLabel.Location = new System.Drawing.Point(12, 4);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(121, 18);
            this.PlayerOneLabel.TabIndex = 0;
            this.PlayerOneLabel.Text = "Player One Label";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerTwoLabel.Location = new System.Drawing.Point(190, 4);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(121, 18);
            this.playerTwoLabel.TabIndex = 1;
            this.playerTwoLabel.Text = "playerTwolabel";
            // 
            // oneWinnerRadioButton
            // 
            this.oneWinnerRadioButton.AutoSize = true;
            this.oneWinnerRadioButton.Location = new System.Drawing.Point(83, 5);
            this.oneWinnerRadioButton.Name = "oneWinnerRadioButton";
            this.oneWinnerRadioButton.Size = new System.Drawing.Size(14, 13);
            this.oneWinnerRadioButton.TabIndex = 1;
            this.oneWinnerRadioButton.TabStop = true;
            this.oneWinnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // twoWinnerRadioButton
            // 
            this.twoWinnerRadioButton.AutoSize = true;
            this.twoWinnerRadioButton.Location = new System.Drawing.Point(252, 3);
            this.twoWinnerRadioButton.Name = "twoWinnerRadioButton";
            this.twoWinnerRadioButton.Size = new System.Drawing.Size(14, 13);
            this.twoWinnerRadioButton.TabIndex = 2;
            this.twoWinnerRadioButton.TabStop = true;
            this.twoWinnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.winnerLabel);
            this.panel1.Controls.Add(this.oneWinnerRadioButton);
            this.panel1.Controls.Add(this.twoWinnerRadioButton);
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 25);
            this.panel1.TabIndex = 2;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(11, 5);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(41, 13);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.Text = "Winner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Army Points \r\nDestroyed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Army Points\r\nDestroyed\r\n";
            // 
            // oneArmynumericUpDown
            // 
            this.oneArmynumericUpDown.Location = new System.Drawing.Point(84, 92);
            this.oneArmynumericUpDown.Name = "oneArmynumericUpDown";
            this.oneArmynumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.oneArmynumericUpDown.TabIndex = 4;
            this.oneArmynumericUpDown.Enter += new System.EventHandler(this.oneArmynumericUpDown_Enter);
            // 
            // oneCPnumericUpDown
            // 
            this.oneCPnumericUpDown.Location = new System.Drawing.Point(84, 60);
            this.oneCPnumericUpDown.Name = "oneCPnumericUpDown";
            this.oneCPnumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.oneCPnumericUpDown.TabIndex = 3;
            this.oneCPnumericUpDown.Enter += new System.EventHandler(this.oneCPnumericUpDown_Enter);
            // 
            // twoCPnumericUpDown
            // 
            this.twoCPnumericUpDown.Location = new System.Drawing.Point(253, 58);
            this.twoCPnumericUpDown.Name = "twoCPnumericUpDown";
            this.twoCPnumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.twoCPnumericUpDown.TabIndex = 5;
            this.twoCPnumericUpDown.Enter += new System.EventHandler(this.twoCPnumericUpDown_Enter);
            // 
            // twoArmynumericUpDown
            // 
            this.twoArmynumericUpDown.Location = new System.Drawing.Point(253, 92);
            this.twoArmynumericUpDown.Name = "twoArmynumericUpDown";
            this.twoArmynumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.twoArmynumericUpDown.TabIndex = 6;
            this.twoArmynumericUpDown.Enter += new System.EventHandler(this.twoArmynumericUpDown_Enter);
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.acceptButton.Location = new System.Drawing.Point(84, 125);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(165, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ResultsRecorderForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(335, 153);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.twoArmynumericUpDown);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.twoCPnumericUpDown);
            this.Controls.Add(this.oneCPnumericUpDown);
            this.Controls.Add(this.oneArmynumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlayerOneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResultsRecorderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matchup Results";
            this.Load += new System.EventHandler(this.ResultsRecorderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneArmynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneCPnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoCPnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoArmynumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.RadioButton oneWinnerRadioButton;
        private System.Windows.Forms.RadioButton twoWinnerRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown oneArmynumericUpDown;
        private System.Windows.Forms.NumericUpDown oneCPnumericUpDown;
        private System.Windows.Forms.NumericUpDown twoCPnumericUpDown;
        private System.Windows.Forms.NumericUpDown twoArmynumericUpDown;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label winnerLabel;
    }
}