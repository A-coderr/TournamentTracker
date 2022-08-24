
namespace TrackerUI
{
    partial class frmCompetitors
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
            this.btnAddCompetitor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCompetitor
            // 
            this.btnAddCompetitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(245)))), ((int)(((byte)(174)))));
            this.btnAddCompetitor.FlatAppearance.BorderSize = 0;
            this.btnAddCompetitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompetitor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCompetitor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCompetitor.Location = new System.Drawing.Point(30, 427);
            this.btnAddCompetitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCompetitor.Name = "btnAddCompetitor";
            this.btnAddCompetitor.Size = new System.Drawing.Size(213, 53);
            this.btnAddCompetitor.TabIndex = 8;
            this.btnAddCompetitor.Text = "Add Competitor";
            this.btnAddCompetitor.UseVisualStyleBackColor = false;
            this.btnAddCompetitor.Click += new System.EventHandler(this.btnAddCompetitor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 328);
            this.dataGridView1.TabIndex = 9;
            // 
            // frmCompetitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(818, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddCompetitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompetitors";
            this.Text = "frmCompetitors";
            this.Load += new System.EventHandler(this.frmCompetitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCompetitor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}