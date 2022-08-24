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
        List<CompetitorModel> availableCompetitors = MainDashboard.mainDashboardInstance.tournament.Competitors;
        List<CompetitorModel> selectedCompetitors = new List<CompetitorModel>();

        public CreateDivision()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            //Loads competitors that registered for tournament in the ComboBox
            cmbComp.DataSource = null;
            cmbComp.DataSource = availableCompetitors;
            cmbComp.DisplayMember = "FirstName";

            lstCompInDiv.DataSource = null;
            lstCompInDiv.DataSource = selectedCompetitors;
            lstCompInDiv.DisplayMember = "FirstName";
        }

        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            DivisionModel divisionModel = new DivisionModel();
            divisionModel.Name = txtDivisionName.Text;
            divisionModel.TournamentId = MainDashboard.mainDashboardInstance.tournament.Id;
            divisionModel.EnteredCompetitors = selectedCompetitors;

            GlobalConfig.Connection.CreateDivision(divisionModel);
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
    }
}
