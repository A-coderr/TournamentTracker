using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class frmCompetitors : Form
    {

        List<CompetitorModel> competitors = new List<CompetitorModel>();

        public frmCompetitors()
        {
            InitializeComponent();

            //Loads competitors that registered for tournament in the DataDridView
            //competitors = MainDashboard.mainDashboardInstance.tournament.Competitors;
            competitors = GlobalConfig.Connection.GetCompetitor_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = competitors;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            //Opens new form to sign up 
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            CreateCompetitor frmCreateCompetitors = new CreateCompetitor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateCompetitors.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frmCreateCompetitors);
            frmCreateCompetitors.Show();
        }

        private void frmCompetitors_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CompetitorModel model = new CompetitorModel();
            model.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            model.FirstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            model.LastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            model.Email = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            model.DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            model.BeltColor = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            model.TournamentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

            //Opens new form to sign up 
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            UDCompetitor ud = new UDCompetitor(model) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ud.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(ud);
            ud.Show();

        }
    }
}
