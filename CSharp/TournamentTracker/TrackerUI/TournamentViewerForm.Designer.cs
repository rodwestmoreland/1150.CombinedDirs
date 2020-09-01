namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoundTournamentLabel = new System.Windows.Forms.Label();
            this.RoundName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.RoundUnplayedCheckbox = new System.Windows.Forms.CheckBox();
            this.RoundMatchupListbox = new System.Windows.Forms.ListBox();
            this.RoundTeamOneName = new System.Windows.Forms.Label();
            this.RoundTeamTwoName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.RoundVSLabel = new System.Windows.Forms.Label();
            this.RoundScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoundTournamentLabel
            // 
            this.RoundTournamentLabel.AutoSize = true;
            this.RoundTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundTournamentLabel.Location = new System.Drawing.Point(51, 32);
            this.RoundTournamentLabel.Name = "RoundTournamentLabel";
            this.RoundTournamentLabel.Size = new System.Drawing.Size(165, 38);
            this.RoundTournamentLabel.TabIndex = 0;
            this.RoundTournamentLabel.Text = "Tournament";
            this.RoundTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundName
            // 
            this.RoundName.AutoSize = true;
            this.RoundName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundName.Location = new System.Drawing.Point(236, 32);
            this.RoundName.Name = "RoundName";
            this.RoundName.Size = new System.Drawing.Size(118, 38);
            this.RoundName.TabIndex = 0;
            this.RoundName.Text = "<none>";
            this.RoundName.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundLabel.Location = new System.Drawing.Point(51, 114);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(83, 32);
            this.RoundLabel.TabIndex = 0;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(152, 106);
            this.RoundDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(320, 46);
            this.RoundDropdown.TabIndex = 1;
            // 
            // RoundUnplayedCheckbox
            // 
            this.RoundUnplayedCheckbox.AutoSize = true;
            this.RoundUnplayedCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoundUnplayedCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundUnplayedCheckbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundUnplayedCheckbox.Location = new System.Drawing.Point(152, 173);
            this.RoundUnplayedCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoundUnplayedCheckbox.Name = "RoundUnplayedCheckbox";
            this.RoundUnplayedCheckbox.Size = new System.Drawing.Size(163, 32);
            this.RoundUnplayedCheckbox.TabIndex = 2;
            this.RoundUnplayedCheckbox.Text = "Unplayed Only";
            this.RoundUnplayedCheckbox.UseVisualStyleBackColor = true;
            this.RoundUnplayedCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RoundMatchupListbox
            // 
            this.RoundMatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoundMatchupListbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundMatchupListbox.FormattingEnabled = true;
            this.RoundMatchupListbox.ItemHeight = 28;
            this.RoundMatchupListbox.Location = new System.Drawing.Point(152, 244);
            this.RoundMatchupListbox.Name = "RoundMatchupListbox";
            this.RoundMatchupListbox.Size = new System.Drawing.Size(320, 282);
            this.RoundMatchupListbox.TabIndex = 3;
            // 
            // RoundTeamOneName
            // 
            this.RoundTeamOneName.AutoSize = true;
            this.RoundTeamOneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundTeamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundTeamOneName.Location = new System.Drawing.Point(538, 244);
            this.RoundTeamOneName.Name = "RoundTeamOneName";
            this.RoundTeamOneName.Size = new System.Drawing.Size(148, 32);
            this.RoundTeamOneName.TabIndex = 0;
            this.RoundTeamOneName.Text = "<team one>";
            this.RoundTeamOneName.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundTeamTwoName
            // 
            this.RoundTeamTwoName.AutoSize = true;
            this.RoundTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundTeamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundTeamTwoName.Location = new System.Drawing.Point(538, 407);
            this.RoundTeamTwoName.Name = "RoundTeamTwoName";
            this.RoundTeamTwoName.Size = new System.Drawing.Size(146, 32);
            this.RoundTeamTwoName.TabIndex = 0;
            this.RoundTeamTwoName.Text = "<team two>";
            this.RoundTeamTwoName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(538, 289);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(73, 32);
            this.TeamOneScoreLabel.TabIndex = 0;
            this.TeamOneScoreLabel.Text = "Score";
            this.TeamOneScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(634, 283);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(107, 45);
            this.TeamOneScoreValue.TabIndex = 4;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(634, 445);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(107, 45);
            this.TeamTwoScoreValue.TabIndex = 4;
            this.TeamTwoScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(538, 453);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(73, 32);
            this.TeamTwoScoreLabel.TabIndex = 0;
            this.TeamTwoScoreLabel.Text = "Score";
            this.TeamTwoScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundVSLabel
            // 
            this.RoundVSLabel.AutoSize = true;
            this.RoundVSLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundVSLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundVSLabel.Location = new System.Drawing.Point(566, 353);
            this.RoundVSLabel.Name = "RoundVSLabel";
            this.RoundVSLabel.Size = new System.Drawing.Size(96, 32);
            this.RoundVSLabel.TabIndex = 0;
            this.RoundVSLabel.Text = "-- VS --";
            this.RoundVSLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundScoreButton
            // 
            this.RoundScoreButton.BackColor = System.Drawing.Color.White;
            this.RoundScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RoundScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoundScoreButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RoundScoreButton.Location = new System.Drawing.Point(758, 353);
            this.RoundScoreButton.Name = "RoundScoreButton";
            this.RoundScoreButton.Size = new System.Drawing.Size(112, 74);
            this.RoundScoreButton.TabIndex = 5;
            this.RoundScoreButton.Text = "Score";
            this.RoundScoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 684);
            this.Controls.Add(this.RoundScoreButton);
            this.Controls.Add(this.RoundVSLabel);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.RoundTeamTwoName);
            this.Controls.Add(this.RoundTeamOneName);
            this.Controls.Add(this.RoundMatchupListbox);
            this.Controls.Add(this.RoundUnplayedCheckbox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.RoundName);
            this.Controls.Add(this.RoundTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentViewerForm";
            this.ShowIcon = false;
            this.Text = "Tourmanment Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoundTournamentLabel;
        private System.Windows.Forms.Label RoundName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox RoundUnplayedCheckbox;
        private System.Windows.Forms.ListBox RoundMatchupListbox;
        private System.Windows.Forms.Label RoundTeamOneName;
        private System.Windows.Forms.Label RoundTeamTwoName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label RoundVSLabel;
        private System.Windows.Forms.Button RoundScoreButton;
    }
}

