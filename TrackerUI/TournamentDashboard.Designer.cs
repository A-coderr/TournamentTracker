
namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.cmbTournaments = new System.Windows.Forms.ComboBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Tracker";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadTournament.ForeColor = System.Drawing.Color.White;
            this.btnLoadTournament.Location = new System.Drawing.Point(282, 196);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(236, 51);
            this.btnLoadTournament.TabIndex = 1;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = false;
            this.btnLoadTournament.Click += new System.EventHandler(this.btnLoadTournament_Click);
            // 
            // cmbTournaments
            // 
            this.cmbTournaments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cmbTournaments.FormattingEnabled = true;
            this.cmbTournaments.Location = new System.Drawing.Point(236, 151);
            this.cmbTournaments.Name = "cmbTournaments";
            this.cmbTournaments.Size = new System.Drawing.Size(329, 32);
            this.cmbTournaments.TabIndex = 2;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateTournament.ForeColor = System.Drawing.Color.White;
            this.btnCreateTournament.Location = new System.Drawing.Point(282, 303);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(236, 51);
            this.btnCreateTournament.TabIndex = 3;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = false;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.cmbTournaments);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.label1);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.Load += new System.EventHandler(this.TournamentDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.ComboBox cmbTournaments;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}

