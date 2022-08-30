using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class frmDivisions : Form
    {
        List<DivisionModel> divisions = new List<DivisionModel>();
        public frmDivisions()
        {
            InitializeComponent();
            divisions = GlobalConfig.Connection.GetDivision_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = divisions;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            CreateDivision frmCreateDivision = new CreateDivision() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateDivision.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frmCreateDivision);
            frmCreateDivision.Show();

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
            UDDivision ud = new UDDivision(model) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ud.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(ud);
            ud.Show();
        }
    }
}
