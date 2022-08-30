
namespace TrackerUI
{
    partial class CreateDivision
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
            this.txtDivisionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDivision = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComp = new System.Windows.Forms.ComboBox();
            this.btnAddToDiv = new System.Windows.Forms.Button();
            this.lstCompInDiv = new System.Windows.Forms.ListBox();
            this.btnRemoveFromDiv = new System.Windows.Forms.Button();
            this.cbClosed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDivType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDivisionName
            // 
            this.txtDivisionName.Location = new System.Drawing.Point(266, 19);
            this.txtDivisionName.Name = "txtDivisionName";
            this.txtDivisionName.Size = new System.Drawing.Size(324, 22);
            this.txtDivisionName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Division Name";
            // 
            // btnAddDivision
            // 
            this.btnAddDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnAddDivision.FlatAppearance.BorderSize = 0;
            this.btnAddDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddDivision.Location = new System.Drawing.Point(343, 389);
            this.btnAddDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDivision.Name = "btnAddDivision";
            this.btnAddDivision.Size = new System.Drawing.Size(213, 53);
            this.btnAddDivision.TabIndex = 20;
            this.btnAddDivision.Text = "Add Division";
            this.btnAddDivision.UseVisualStyleBackColor = false;
            this.btnAddDivision.Click += new System.EventHandler(this.btnAddDivision_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Competitors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(20, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 34);
            this.label4.TabIndex = 30;
            this.label4.Text = "Select Competitor";
            // 
            // cmbComp
            // 
            this.cmbComp.FormattingEnabled = true;
            this.cmbComp.Location = new System.Drawing.Point(306, 271);
            this.cmbComp.Name = "cmbComp";
            this.cmbComp.Size = new System.Drawing.Size(236, 24);
            this.cmbComp.TabIndex = 31;
            // 
            // btnAddToDiv
            // 
            this.btnAddToDiv.Location = new System.Drawing.Point(583, 271);
            this.btnAddToDiv.Name = "btnAddToDiv";
            this.btnAddToDiv.Size = new System.Drawing.Size(131, 36);
            this.btnAddToDiv.TabIndex = 32;
            this.btnAddToDiv.Text = "Add to Division";
            this.btnAddToDiv.UseVisualStyleBackColor = true;
            this.btnAddToDiv.Click += new System.EventHandler(this.btnAddToDiv_Click);
            // 
            // lstCompInDiv
            // 
            this.lstCompInDiv.FormattingEnabled = true;
            this.lstCompInDiv.ItemHeight = 16;
            this.lstCompInDiv.Location = new System.Drawing.Point(266, 139);
            this.lstCompInDiv.Name = "lstCompInDiv";
            this.lstCompInDiv.Size = new System.Drawing.Size(324, 84);
            this.lstCompInDiv.TabIndex = 33;
            // 
            // btnRemoveFromDiv
            // 
            this.btnRemoveFromDiv.Location = new System.Drawing.Point(609, 162);
            this.btnRemoveFromDiv.Name = "btnRemoveFromDiv";
            this.btnRemoveFromDiv.Size = new System.Drawing.Size(159, 36);
            this.btnRemoveFromDiv.TabIndex = 34;
            this.btnRemoveFromDiv.Text = "Remove from Division";
            this.btnRemoveFromDiv.UseVisualStyleBackColor = true;
            this.btnRemoveFromDiv.Click += new System.EventHandler(this.btnRemoveFromDiv_Click);
            // 
            // cbClosed
            // 
            this.cbClosed.AutoSize = true;
            this.cbClosed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbClosed.Location = new System.Drawing.Point(275, 337);
            this.cbClosed.Name = "cbClosed";
            this.cbClosed.Size = new System.Drawing.Size(118, 21);
            this.cbClosed.TabIndex = 35;
            this.cbClosed.Text = "Close Division";
            this.cbClosed.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "Division Type";
            // 
            // cmbDivType
            // 
            this.cmbDivType.FormattingEnabled = true;
            this.cmbDivType.Location = new System.Drawing.Point(266, 72);
            this.cmbDivType.Name = "cmbDivType";
            this.cmbDivType.Size = new System.Drawing.Size(236, 24);
            this.cmbDivType.TabIndex = 37;
            // 
            // CreateDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.cmbDivType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClosed);
            this.Controls.Add(this.btnRemoveFromDiv);
            this.Controls.Add(this.lstCompInDiv);
            this.Controls.Add(this.btnAddToDiv);
            this.Controls.Add(this.cmbComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDivisionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDivision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateDivision";
            this.Text = "CreateDivision";
            this.Load += new System.EventHandler(this.CreateDivision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDivisionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDivision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComp;
        private System.Windows.Forms.Button btnAddToDiv;
        private System.Windows.Forms.ListBox lstCompInDiv;
        private System.Windows.Forms.Button btnRemoveFromDiv;
        private System.Windows.Forms.CheckBox cbClosed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDivType;
    }
}