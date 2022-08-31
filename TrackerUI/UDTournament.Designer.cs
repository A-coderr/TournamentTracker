
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
            this.btnDeleteT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(131, 118);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(246, 22);
            this.txtTournamentName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(131, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tournament Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(131, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tournament Date";
            // 
            // txtTournamentDate
            // 
            this.txtTournamentDate.Location = new System.Drawing.Point(131, 206);
            this.txtTournamentDate.Name = "txtTournamentDate";
            this.txtTournamentDate.Size = new System.Drawing.Size(200, 22);
            this.txtTournamentDate.TabIndex = 8;
            // 
            // btnUpdateT
            // 
            this.btnUpdateT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnUpdateT.FlatAppearance.BorderSize = 0;
            this.btnUpdateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateT.ForeColor = System.Drawing.Color.White;
            this.btnUpdateT.Location = new System.Drawing.Point(233, 375);
            this.btnUpdateT.Name = "btnUpdateT";
            this.btnUpdateT.Size = new System.Drawing.Size(135, 58);
            this.btnUpdateT.TabIndex = 7;
            this.btnUpdateT.Text = "Update";
            this.btnUpdateT.UseVisualStyleBackColor = false;
            this.btnUpdateT.Click += new System.EventHandler(this.btnUpdateT_Click);
            // 
            // btnDeleteT
            // 
            this.btnDeleteT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnDeleteT.FlatAppearance.BorderSize = 0;
            this.btnDeleteT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteT.ForeColor = System.Drawing.Color.White;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnDeleteT);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTournamentDate);
            this.Controls.Add(this.btnUpdateT);
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
        private System.Windows.Forms.Button btnDeleteT;
    }
}