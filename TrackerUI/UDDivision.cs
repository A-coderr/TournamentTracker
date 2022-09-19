using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class UDDivision : Form
    {
        public DivisionModel division;
        List<CompetitorModel> selectedCompetitors = new List<CompetitorModel>();
        List<CompetitorModel> availableCompetitors = GlobalConfig.Connection.GetCompetitor_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);

        List<CompetitorModel> competitorsToAdd = new List<CompetitorModel>();
        List<CompetitorModel> competitorsToRemove = GlobalConfig.Connection.GetCompetitor_ByTournament(MainDashboard.mainDashboardInstance.tournament.Id);
        List<DivisionTypeModel> divisionType = GlobalConfig.Connection.GetDivisionType_All();
        bool closed = false;
        string message = "";

        public UDDivision(DivisionModel divisionM)
        {
            InitializeComponent();
            division = divisionM;
            selectedCompetitors = GlobalConfig.Connection.GetCompetitor_ByDivision(division.Id);
            competitorsToAdd = GlobalConfig.Connection.GetCompetitor_ByDivision(division.Id);
            competitorsToRemove.RemoveAll(x => selectedCompetitors.Exists(y => y.Id == x.Id));

            //Removes all competitors that exists in list selected competitors
            availableCompetitors.RemoveAll(x => selectedCompetitors.Exists(y => y.Id == x.Id));            
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

            lblEntries.Text = $"Total Entries: {selectedCompetitors.Count}";
        }

        private void UDDivision_Load(object sender, EventArgs e)
        {
            txtDivisionName.Text = division.Name;
            cmbDivType.SelectedIndex = division.Type - 1;
            closed = division.DivisionClosed;
            if(closed == true)
            {
                cbClosed.Checked = true;
            }
        }

        private void btnUpdateDivision_Click(object sender, EventArgs e)
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
                selectedCompetitors.RemoveAll(x => competitorsToAdd.Exists(y => y.Id == x.Id));
                availableCompetitors.RemoveAll(x => competitorsToRemove.Exists(y => y.Id == x.Id));
                DivisionModel divisionModel = new DivisionModel();
                divisionModel.Id = division.Id;
                divisionModel.Name = txtDivisionName.Text;
                divisionModel.TournamentId = MainDashboard.mainDashboardInstance.tournament.Id;
                divisionModel.EnteredCompetitors = selectedCompetitors;
                divisionModel.Type = cmbDivType.SelectedIndex + 1;
                divisionModel.DivisionClosed = closed;
                divisionModel.CompetitorsToRemove = availableCompetitors;

                GlobalConfig.Connection.UpdateDivision(divisionModel);
                MessageBox.Show("Division was Updated");

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
            if (closed == true && selectedCompetitors.Count > 0)
            {
                message = "Division has to be open to add more competitors";
                return false;
            }
            return true;
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

        private void btnAddToDiv_Click(object sender, EventArgs e)
        {
            CompetitorModel c = (CompetitorModel)cmbComp.SelectedItem;
            if (c != null)
            {
                availableCompetitors.Remove(c);
                selectedCompetitors.Add(c);
                InitializeLists();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            frmDivisions frm = new frmDivisions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnDeleteDivision_Click(object sender, EventArgs e)
        {
            DivisionModel divisionModel = new DivisionModel();
            divisionModel.Id = division.Id;
            divisionModel.EnteredCompetitors = competitorsToAdd;

            GlobalConfig.Connection.DeleteDivision(divisionModel);
            MessageBox.Show("Division was Updated");

            //Removes division from Tournament Instance
            MainDashboard.mainDashboardInstance.tournament.Divisions.Remove(divisionModel);

            //Returns to the Divisions form
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            frmDivisions frm = new frmDivisions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
