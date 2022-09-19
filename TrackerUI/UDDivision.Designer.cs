
namespace TrackerUI
{
    partial class UDDivision
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
            this.cmbDivType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbClosed = new System.Windows.Forms.CheckBox();
            this.btnRemoveFromDiv = new System.Windows.Forms.Button();
            this.lstCompInDiv = new System.Windows.Forms.ListBox();
            this.btnAddToDiv = new System.Windows.Forms.Button();
            this.cmbComp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDivisionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateDivision = new System.Windows.Forms.Button();
            this.btnDeleteDivision = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEntries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDivType
            // 
            this.cmbDivType.FormattingEnabled = true;
            this.cmbDivType.Location = new System.Drawing.Point(254, 92);
            this.cmbDivType.Name = "cmbDivType";
            this.cmbDivType.Size = new System.Drawing.Size(324, 24);
            this.cmbDivType.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Division Type";
            // 
            // cbClosed
            // 
            this.cbClosed.AutoSize = true;
            this.cbClosed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.cbClosed.Location = new System.Drawing.Point(254, 345);
            this.cbClosed.Name = "cbClosed";
            this.cbClosed.Size = new System.Drawing.Size(166, 28);
            this.cbClosed.TabIndex = 47;
            this.cbClosed.Text = "Close Division";
            this.cbClosed.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromDiv
            // 
            this.btnRemoveFromDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnRemoveFromDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromDiv.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromDiv.Location = new System.Drawing.Point(615, 159);
            this.btnRemoveFromDiv.Name = "btnRemoveFromDiv";
            this.btnRemoveFromDiv.Size = new System.Drawing.Size(120, 50);
            this.btnRemoveFromDiv.TabIndex = 46;
            this.btnRemoveFromDiv.Text = "Remove";
            this.btnRemoveFromDiv.UseVisualStyleBackColor = false;
            this.btnRemoveFromDiv.Click += new System.EventHandler(this.btnRemoveFromDiv_Click);
            // 
            // lstCompInDiv
            // 
            this.lstCompInDiv.FormattingEnabled = true;
            this.lstCompInDiv.ItemHeight = 16;
            this.lstCompInDiv.Location = new System.Drawing.Point(254, 159);
            this.lstCompInDiv.Name = "lstCompInDiv";
            this.lstCompInDiv.Size = new System.Drawing.Size(324, 84);
            this.lstCompInDiv.TabIndex = 45;
            // 
            // btnAddToDiv
            // 
            this.btnAddToDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnAddToDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToDiv.ForeColor = System.Drawing.Color.White;
            this.btnAddToDiv.Location = new System.Drawing.Point(615, 285);
            this.btnAddToDiv.Name = "btnAddToDiv";
            this.btnAddToDiv.Size = new System.Drawing.Size(120, 50);
            this.btnAddToDiv.TabIndex = 44;
            this.btnAddToDiv.Text = "Add";
            this.btnAddToDiv.UseVisualStyleBackColor = false;
            this.btnAddToDiv.Click += new System.EventHandler(this.btnAddToDiv_Click);
            // 
            // cmbComp
            // 
            this.cmbComp.FormattingEnabled = true;
            this.cmbComp.Location = new System.Drawing.Point(254, 285);
            this.cmbComp.Name = "cmbComp";
            this.cmbComp.Size = new System.Drawing.Size(324, 24);
            this.cmbComp.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(13, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Select Competitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Competitors";
            // 
            // txtDivisionName
            // 
            this.txtDivisionName.Location = new System.Drawing.Point(254, 33);
            this.txtDivisionName.Name = "txtDivisionName";
            this.txtDivisionName.Size = new System.Drawing.Size(324, 22);
            this.txtDivisionName.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Division Name";
            // 
            // btnUpdateDivision
            // 
            this.btnUpdateDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnUpdateDivision.FlatAppearance.BorderSize = 0;
            this.btnUpdateDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDivision.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDivision.Location = new System.Drawing.Point(157, 403);
            this.btnUpdateDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDivision.Name = "btnUpdateDivision";
            this.btnUpdateDivision.Size = new System.Drawing.Size(213, 53);
            this.btnUpdateDivision.TabIndex = 38;
            this.btnUpdateDivision.Text = "Update";
            this.btnUpdateDivision.UseVisualStyleBackColor = false;
            this.btnUpdateDivision.Click += new System.EventHandler(this.btnUpdateDivision_Click);
            // 
            // btnDeleteDivision
            // 
            this.btnDeleteDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnDeleteDivision.FlatAppearance.BorderSize = 0;
            this.btnDeleteDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDivision.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDivision.Location = new System.Drawing.Point(474, 403);
            this.btnDeleteDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDivision.Name = "btnDeleteDivision";
            this.btnDeleteDivision.Size = new System.Drawing.Size(213, 53);
            this.btnDeleteDivision.TabIndex = 50;
            this.btnDeleteDivision.Text = "Delete";
            this.btnDeleteDivision.UseVisualStyleBackColor = false;
            this.btnDeleteDivision.Click += new System.EventHandler(this.btnDeleteDivision_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.btnCancel.Location = new System.Drawing.Point(727, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 44);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(41)))), ((int)(((byte)(133)))));
            this.lblEntries.Location = new System.Drawing.Point(14, 196);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(109, 24);
            this.lblEntries.TabIndex = 52;
            this.lblEntries.Text = "Total Entries";
            // 
            // UDDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteDivision);
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
            this.Controls.Add(this.btnUpdateDivision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UDDivision";
            this.Text = "UDDivision";
            this.Load += new System.EventHandler(this.UDDivision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDivType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbClosed;
        private System.Windows.Forms.Button btnRemoveFromDiv;
        private System.Windows.Forms.ListBox lstCompInDiv;
        private System.Windows.Forms.Button btnAddToDiv;
        private System.Windows.Forms.ComboBox cmbComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDivisionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateDivision;
        private System.Windows.Forms.Button btnDeleteDivision;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEntries;
    }
}