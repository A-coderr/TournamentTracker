
namespace TrackerUI
{
    partial class UDTournament
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
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTournamentDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(171, 196);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(246, 22);
            this.txtTournamentName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(168, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tournament Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(165, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tournament Date";
            // 
            // txtTournamentDate
            // 
            this.txtTournamentDate.Location = new System.Drawing.Point(168, 284);
            this.txtTournamentDate.Name = "txtTournamentDate";
            this.txtTournamentDate.Size = new System.Drawing.Size(200, 22);
            this.txtTournamentDate.TabIndex = 8;
            // 
            // btnUpdateT
            // 
            this.btnUpdateT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnUpdateT.FlatAppearance.BorderSize = 0;
            this.btnUpdateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateT.Location = new System.Drawing.Point(233, 375);
            this.btnUpdateT.Name = "btnUpdateT";
            this.btnUpdateT.Size = new System.Drawing.Size(135, 58);
            this.btnUpdateT.TabIndex = 7;
            this.btnUpdateT.Text = "Update";
            this.btnUpdateT.UseVisualStyleBackColor = false;
            this.btnUpdateT.Click += new System.EventHandler(this.btnUpdateT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(261, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tournament Settings";
            // 
            // btnDeleteT
            // 
            this.btnDeleteT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnDeleteT.FlatAppearance.BorderSize = 0;
            this.btnDeleteT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteT.Location = new System.Drawing.Point(464, 375);
            this.btnDeleteT.Name = "btnDeleteT";
            this.btnDeleteT.Size = new System.Drawing.Size(135, 58);
            this.btnDeleteT.TabIndex = 12;
            this.btnDeleteT.Text = "Delete";
            this.btnDeleteT.UseVisualStyleBackColor = false;
            // 
            // UDTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnDeleteT);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTournamentDate);
            this.Controls.Add(this.btnUpdateT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDTournament";
            this.Text = "UDTournament";
            this.Load += new System.EventHandler(this.UDTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtTournamentDate;
        private System.Windows.Forms.Button btnUpdateT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteT;
    }
}