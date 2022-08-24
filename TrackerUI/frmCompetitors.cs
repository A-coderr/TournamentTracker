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
            competitors = MainDashboard.mainDashboardInstance.tournament.Competitors;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = competitors;
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
    }
}
