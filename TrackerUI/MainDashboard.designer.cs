
namespace TrackerUI
{
    partial class MainDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTracker = new System.Windows.Forms.Button();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.btnDivisions = new System.Windows.Forms.Button();
            this.btnCompetitors = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnTracker);
            this.panel1.Controls.Add(this.btnGenerator);
            this.panel1.Controls.Add(this.btnDivisions);
            this.panel1.Controls.Add(this.btnCompetitors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 630);
            this.panel1.TabIndex = 0;
            // 
            // btnTracker
            // 
            this.btnTracker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTracker.FlatAppearance.BorderSize = 0;
            this.btnTracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTracker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnTracker.Location = new System.Drawing.Point(0, 279);
            this.btnTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTracker.Name = "btnTracker";
            this.btnTracker.Size = new System.Drawing.Size(281, 93);
            this.btnTracker.TabIndex = 3;
            this.btnTracker.Text = "Tracker";
            this.btnTracker.UseVisualStyleBackColor = true;
            this.btnTracker.Click += new System.EventHandler(this.btnTracker_Click);
            this.btnTracker.Leave += new System.EventHandler(this.btnTracker_Leave);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerator.FlatAppearance.BorderSize = 0;
            this.btnGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerator.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnGenerator.Location = new System.Drawing.Point(0, 186);
            this.btnGenerator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(281, 93);
            this.btnGenerator.TabIndex = 2;
            this.btnGenerator.Text = "Generator";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            this.btnGenerator.Leave += new System.EventHandler(this.btnGenerator_Leave);
            // 
            // btnDivisions
            // 
            this.btnDivisions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDivisions.FlatAppearance.BorderSize = 0;
            this.btnDivisions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDivisions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnDivisions.Location = new System.Drawing.Point(0, 93);
            this.btnDivisions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivisions.Name = "btnDivisions";
            this.btnDivisions.Size = new System.Drawing.Size(281, 93);
            this.btnDivisions.TabIndex = 1;
            this.btnDivisions.Text = "Divisions";
            this.btnDivisions.UseVisualStyleBackColor = true;
            this.btnDivisions.Click += new System.EventHandler(this.btnDivisions_Click);
            this.btnDivisions.Leave += new System.EventHandler(this.btnDivisions_Leave);
            // 
            // btnCompetitors
            // 
            this.btnCompetitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetitors.FlatAppearance.BorderSize = 0;
            this.btnCompetitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetitors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompetitors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnCompetitors.Location = new System.Drawing.Point(0, 0);
            this.btnCompetitors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompetitors.Name = "btnCompetitors";
            this.btnCompetitors.Size = new System.Drawing.Size(281, 93);
            this.btnCompetitors.TabIndex = 0;
            this.btnCompetitors.Text = "Competitors";
            this.btnCompetitors.UseVisualStyleBackColor = true;
            this.btnCompetitors.Click += new System.EventHandler(this.btnCompetitors_Click);
            this.btnCompetitors.Leave += new System.EventHandler(this.btnCompetitors_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblTitle.Location = new System.Drawing.Point(326, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Competitors";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(281, 93);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(818, 537);
            this.pnlFormLoader.TabIndex = 5;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTournamentName.Location = new System.Drawing.Point(672, 38);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(136, 17);
            this.lblTournamentName.TabIndex = 6;
            this.lblTournamentName.Text = "lblTournamentName";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1099, 630);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTracker;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Button btnDivisions;
        private System.Windows.Forms.Button btnCompetitors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblTournamentName;
    }
}