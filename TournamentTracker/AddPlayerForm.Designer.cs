namespace TournamentTracker
{
    partial class AddPlayerForm
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
            this.factionComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.Factionlabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.winsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.winsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.APDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.winsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APDNumericUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.factionComboBox.Location = new System.Drawing.Point(109, 66);
            this.factionComboBox.Name = "factionComboBox";
            this.factionComboBox.Size = new System.Drawing.Size(121, 21);
            this.factionComboBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // Factionlabel
            // 
            this.Factionlabel.Location = new System.Drawing.Point(14, 66);
            this.Factionlabel.Name = "Factionlabel";
            this.Factionlabel.Size = new System.Drawing.Size(59, 23);
            this.Factionlabel.TabIndex = 15;
            this.Factionlabel.Text = "Faction";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.Location = new System.Drawing.Point(14, 39);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(59, 23);
            this.LastNamelabel.TabIndex = 13;
            this.LastNamelabel.Text = "Last Name";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(14, 12);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(59, 23);
            this.FirstNamelabel.TabIndex = 11;
            this.FirstNamelabel.Text = "First Name";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(132, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(32, 171);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(95, 23);
            this.addPlayerButton.TabIndex = 16;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // winsNumericUpDown
            // 
            this.winsNumericUpDown.Location = new System.Drawing.Point(143, 93);
            this.winsNumericUpDown.Name = "winsNumericUpDown";
            this.winsNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.winsNumericUpDown.TabIndex = 18;
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(14, 95);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(31, 13);
            this.winsLabel.TabIndex = 19;
            this.winsLabel.Text = "Wins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Control Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Army Points Destroyed";
            // 
            // CPNumericUpDown
            // 
            this.CPNumericUpDown.Location = new System.Drawing.Point(143, 119);
            this.CPNumericUpDown.Name = "CPNumericUpDown";
            this.CPNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.CPNumericUpDown.TabIndex = 22;
            // 
            // APDNumericUpDown
            // 
            this.APDNumericUpDown.Location = new System.Drawing.Point(143, 143);
            this.APDNumericUpDown.Name = "APDNumericUpDown";
            this.APDNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.APDNumericUpDown.TabIndex = 23;
            // 
            // AddPlayerForm
            // 
            this.AcceptButton = this.addPlayerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(242, 206);
            this.Controls.Add(this.APDNumericUpDown);
            this.Controls.Add(this.CPNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.winsNumericUpDown);
            this.Controls.Add(this.factionComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.Factionlabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addPlayerButton);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.winsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox factionComboBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label Factionlabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.NumericUpDown winsNumericUpDown;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CPNumericUpDown;
        private System.Windows.Forms.NumericUpDown APDNumericUpDown;
    }
}