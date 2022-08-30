using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateDivision : Form
    {
        List<CompetitorModel> availableCompetitors = GlobalConfig.Connection.GetCompetitor_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);
        List<CompetitorModel> selectedCompetitors = new List<CompetitorModel>();
        List<DivisionTypeModel> divisionType = GlobalConfig.Connection.GetDivisionType_All();
        bool closed = false;
        string message = "";

        public CreateDivision()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            //Populates ComboBox with Division Types
            cmbDivType.DataSource = null;
            cmbDivType.DataSource = divisionType;
            cmbDivType.DisplayMember = "Type";

            //Loads competitors that registered for tournament in the ComboBox
            cmbComp.DataSource = null;
            cmbComp.DataSource = availableCompetitors;
            cmbComp.DisplayMember = "FullName";

            lstCompInDiv.DataSource = null;
            lstCompInDiv.DataSource = selectedCompetitors;
            lstCompInDiv.DisplayMember = "FullName";
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            if (cbClosed.Checked)
            {
                closed = true;
            }
            else
            {
                closed = false;
            }

            //Calls form validation
            if (ValidateForm())
            {
                DivisionModel divisionModel = new DivisionModel();
                divisionModel.Name = txtDivisionName.Text;
                divisionModel.TournamentId = MainDashboard.mainDashboardInstance.tournament.Id;
                divisionModel.EnteredCompetitors = selectedCompetitors;
                divisionModel.Type = cmbDivType.SelectedIndex + 1;
                divisionModel.DivisionClosed = closed;

                GlobalConfig.Connection.CreateDivision(divisionModel);
                MessageBox.Show($"{txtDivisionName.Text} was created!");

                //Adds division to Tournament Instance
                MainDashboard.mainDashboardInstance.tournament.Divisions.Add(divisionModel);

                //Returns to the Divisions form
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
                frmDivisions frm = new frmDivisions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show(message);
                message = "";
            }

        }

        private bool ValidateForm()
        {
            if (txtDivisionName.Text.Length == 0)
            {
                message = "Division Name cannot be empty";
                return false;
            }
            if(closed == true && selectedCompetitors.Count > 0)
            {
                message = "Division has to be open to add more competitors";
                return false;
            }          
            return true;
        }

        private void btnAddToDiv_Click(object sender, EventArgs e)
        {
            CompetitorModel c = (CompetitorModel)cmbComp.SelectedItem;
            if(c != null)
            {
                availableCompetitors.Remove(c);
                selectedCompetitors.Add(c);
                InitializeLists();
            }
        }

        private void btnRemoveFromDiv_Click(object sender, EventArgs e)
        {
            CompetitorModel c = (CompetitorModel)lstCompInDiv.SelectedItem;
            if (c != null)
            {
                selectedCompetitors.Remove(c);
                availableCompetitors.Add(c);
                InitializeLists();
            }
        }

        private void CreateDivision_Load(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(GlobalConfig.ConString("DatabaseConnection"));
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM DivisionType", connection);
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    cmbDivType.Items.Add(reader["Type"]);
            //}
            //connection.Close();
        }
    }
}
