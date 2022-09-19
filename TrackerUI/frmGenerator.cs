using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class frmGenerator : Form
    {
        List<DivisionModel> divisions = new List<DivisionModel>();
        public frmGenerator()
        {
            InitializeComponent();
            divisions = GlobalConfig.Connection.GetDivision_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = divisions;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void frmGenerator_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DivisionModel model = new DivisionModel();
            model.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            model.Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            model.Type = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            model.TournamentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            model.DivisionClosed = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            //Opens new form to sign up 
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            GenerateDivision gd = new GenerateDivision(model) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gd.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(gd);
            gd.Show();
        }
    }
}
