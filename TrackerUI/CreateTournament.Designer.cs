
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
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Tournament";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreateT
            // 
            this.btnCreateT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.btnCreateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateT.ForeColor = System.Drawing.Color.White;
            this.btnCreateT.Location = new System.Drawing.Point(333, 335);
            this.btnCreateT.Name = "btnCreateT";
            this.btnCreateT.Size = new System.Drawing.Size(135, 58);
            this.btnCreateT.TabIndex = 1;
            this.btnCreateT.Text = "Create";
            this.btnCreateT.UseVisualStyleBackColor = false;
            this.btnCreateT.Click += new System.EventHandler(this.btnCreateT_Click);
            // 
            // txtTournamentDate
            // 
            this.txtTournamentDate.Location = new System.Drawing.Point(357, 241);
            this.txtTournamentDate.Name = "txtTournamentDate";
            this.txtTournamentDate.Size = new System.Drawing.Size(331, 22);
            this.txtTournamentDate.TabIndex = 2;
            this.txtTournamentDate.ValueChanged += new System.EventHandler(this.txtTournamentDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tournament Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tournament Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(357, 173);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(331, 22);
            this.txtTournamentName.TabIndex = 5;
            this.txtTournamentName.TextChanged += new System.EventHandler(this.txtTournamentName_TextChanged);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
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