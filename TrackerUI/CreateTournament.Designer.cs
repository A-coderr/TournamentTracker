
namespace TrackerUI
{
    partial class CreateTournament
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
            this.btnCreateT = new System.Windows.Forms.Button();
            this.txtTournamentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(276, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Tournament";
            // 
            // btnCreateT
            // 
            this.btnCreateT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnCreateT.FlatAppearance.BorderSize = 0;
            this.btnCreateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateT.Location = new System.Drawing.Point(357, 335);
            this.btnCreateT.Name = "btnCreateT";
            this.btnCreateT.Size = new System.Drawing.Size(135, 58);
            this.btnCreateT.TabIndex = 1;
            this.btnCreateT.Text = "Create";
            this.btnCreateT.UseVisualStyleBackColor = false;
            this.btnCreateT.Click += new System.EventHandler(this.btnCreateT_Click);
            // 
            // txtTournamentDate
            // 
            this.txtTournamentDate.Location = new System.Drawing.Point(82, 266);
            this.txtTournamentDate.Name = "txtTournamentDate";
            this.txtTournamentDate.Size = new System.Drawing.Size(200, 22);
            this.txtTournamentDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(79, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tournament Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(82, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tournament Name";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(85, 178);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(246, 22);
            this.txtTournamentName.TabIndex = 5;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTournamentDate);
            this.Controls.Add(this.btnCreateT);
            this.Controls.Add(this.label1);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateT;
        private System.Windows.Forms.DateTimePicker txtTournamentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTournamentName;
    }
}