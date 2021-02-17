namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.TournamentDashboardLoadTournamentCombo = new System.Windows.Forms.ComboBox();
            this.TournamentDashboardLoadTournamentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TournamentDashboardCreateTournamentButton = new System.Windows.Forms.Button();
            this.TournamentDashboardLoadTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLoadTournamentCombo
            // 
            this.TournamentDashboardLoadTournamentCombo.FormattingEnabled = true;
            this.TournamentDashboardLoadTournamentCombo.Location = new System.Drawing.Point(24, 144);
            this.TournamentDashboardLoadTournamentCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TournamentDashboardLoadTournamentCombo.Name = "TournamentDashboardLoadTournamentCombo";
            this.TournamentDashboardLoadTournamentCombo.Size = new System.Drawing.Size(434, 46);
            this.TournamentDashboardLoadTournamentCombo.TabIndex = 1;
            // 
            // TournamentDashboardLoadTournamentLabel
            // 
            this.TournamentDashboardLoadTournamentLabel.AutoSize = true;
            this.TournamentDashboardLoadTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardLoadTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentDashboardLoadTournamentLabel.Location = new System.Drawing.Point(24, 91);
            this.TournamentDashboardLoadTournamentLabel.Name = "TournamentDashboardLoadTournamentLabel";
            this.TournamentDashboardLoadTournamentLabel.Size = new System.Drawing.Size(289, 32);
            this.TournamentDashboardLoadTournamentLabel.TabIndex = 0;
            this.TournamentDashboardLoadTournamentLabel.Text = "Load Existing Tournament";
            this.TournamentDashboardLoadTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tournament Dashboard";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentDashboardCreateTournamentButton
            // 
            this.TournamentDashboardCreateTournamentButton.BackColor = System.Drawing.Color.White;
            this.TournamentDashboardCreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TournamentDashboardCreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentDashboardCreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardCreateTournamentButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TournamentDashboardCreateTournamentButton.Location = new System.Drawing.Point(74, 327);
            this.TournamentDashboardCreateTournamentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TournamentDashboardCreateTournamentButton.Name = "TournamentDashboardCreateTournamentButton";
            this.TournamentDashboardCreateTournamentButton.Size = new System.Drawing.Size(317, 49);
            this.TournamentDashboardCreateTournamentButton.TabIndex = 5;
            this.TournamentDashboardCreateTournamentButton.Text = "Create Tournament";
            this.TournamentDashboardCreateTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardLoadTournamentButton
            // 
            this.TournamentDashboardLoadTournamentButton.BackColor = System.Drawing.Color.White;
            this.TournamentDashboardLoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TournamentDashboardLoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentDashboardLoadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardLoadTournamentButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TournamentDashboardLoadTournamentButton.Location = new System.Drawing.Point(74, 221);
            this.TournamentDashboardLoadTournamentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TournamentDashboardLoadTournamentButton.Name = "TournamentDashboardLoadTournamentButton";
            this.TournamentDashboardLoadTournamentButton.Size = new System.Drawing.Size(317, 49);
            this.TournamentDashboardLoadTournamentButton.TabIndex = 5;
            this.TournamentDashboardLoadTournamentButton.Text = "Load Tournament";
            this.TournamentDashboardLoadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(488, 463);
            this.Controls.Add(this.TournamentDashboardLoadTournamentButton);
            this.Controls.Add(this.TournamentDashboardCreateTournamentButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TournamentDashboardLoadTournamentLabel);
            this.Controls.Add(this.TournamentDashboardLoadTournamentCombo);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentDashboardForm";
            this.ShowIcon = false;
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TournamentDashboardLoadTournamentCombo;
        private System.Windows.Forms.Label TournamentDashboardLoadTournamentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TournamentDashboardCreateTournamentButton;
        private System.Windows.Forms.Button TournamentDashboardLoadTournamentButton;
    }
}