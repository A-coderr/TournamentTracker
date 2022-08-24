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

namespace TrackerUI
{
    public partial class frmDivisions : Form
    {
        List<DivisionModel> divisions = new List<DivisionModel>();
        string conString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;     
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public frmDivisions()
        {
            InitializeComponent();
            InitializeLists();
            //SqlConnection connection = new SqlConnection(conString);
            //connection.Open();
            //adapter = new SqlDataAdapter("SELECT * FROM Division", connection);
            //dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //dataGridView1.DataSource = dataTable;
            //connection.Close();
        }
        private void InitializeLists()
        {
            divisions = MainDashboard.mainDashboardInstance.tournament.Divisions;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = divisions;

        }
        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            CreateDivision frmCreateDivision = new CreateDivision() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateDivision.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frmCreateDivision);
            frmCreateDivision.Show();

        }


    }
}
