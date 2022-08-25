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
    public partial class UDCompetitor : Form
    {
        int beltColor = 0;
        public CompetitorModel competitorModel;
        public UDCompetitor(CompetitorModel competitor)
        {
            InitializeComponent();
            competitorModel = competitor;
        }

        private void btnUpdateComp_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CompetitorModel model = new CompetitorModel(competitorModel.Id, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtDateOfBirth.Value, cmbBeltColor.Text, competitorModel.TournamentId);    
                GlobalConfig.Connection.UpdateCompetitor(model);

                //Clears text boxes for the next use
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtDateOfBirth.Value = DateTime.Now;
                cmbBeltColor.SelectedValue = 0;
                MessageBox.Show("Competitor Updated");

                //Returns to the Competitors form
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
                frmCompetitors frm = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Form is Invalid");
            }
        }

        private void UDCompetitor_Load(object sender, EventArgs e)
        {
            cmbBeltColor.DataSource = new BeltColor[] {
            new BeltColor{ Id = 0, Color = "..." },
            new BeltColor{ Id = 1, Color = "White" },
            new BeltColor{ Id = 2, Color = "Yellow" },
            new BeltColor{ Id = 3, Color = "Orange" },
            new BeltColor{ Id = 4, Color = "Blue" },
            new BeltColor{ Id = 5, Color = "Purple" },
            new BeltColor{ Id = 6, Color = "Green" },
            new BeltColor{ Id = 7, Color = "Green with White Stripe" },
            new BeltColor{ Id = 8, Color = "Green with Black Stripe" },
            new BeltColor{ Id = 9, Color = "Red" },
            new BeltColor{ Id = 10, Color = "Red with White Stripe" },
            new BeltColor{ Id = 11, Color = "Red with Black Stripe" },
            new BeltColor{ Id = 12, Color = "Brown" },
            new BeltColor{ Id = 13, Color = "Brown with White Stripe" },
            new BeltColor{ Id = 14, Color = "Brown with Black Stripe" },
            new BeltColor{ Id = 15, Color = "Black with White Stripe and Up" }
            };

            cmbBeltColor.DisplayMember = "Color";
            cmbBeltColor.ValueMember = "Id";

            switch (competitorModel.BeltColor)
            {
                case "White":
                    beltColor = 1;
                    break;
                case "Yellow":
                    beltColor = 2;
                    break;
                case "Orange":
                    beltColor = 3;
                    break;
                case "Blue":
                    beltColor = 4;
                    break;
                case "Purple":
                    beltColor = 5;
                    break;
                case "Green":
                    beltColor = 6;
                    break;
                case "Green with White Stripe":
                    beltColor = 7;
                    break;
                case "Green with Black Stripe":
                    beltColor = 8;
                    break;
                case "Red":
                    beltColor = 9;
                    break;
                case "Red with White Stripe":
                    beltColor = 10;
                    break;
                case "Red with Black Stripe":
                    beltColor = 11;
                    break;
                case "Brown":
                    beltColor = 12;
                    break;
                case "Brown with White Stripe":
                    beltColor = 13;
                    break;
                case "Brown with Black Stripe":
                    beltColor = 14;
                    break;
                case "Black with White Stripe and Up":
                    beltColor = 15;
                    break;              
                default:
                    break;
            }
            txtFirstName.Text = competitorModel.FirstName;
            txtLastName.Text = competitorModel.LastName;
            txtEmail.Text = competitorModel.Email;
            txtDateOfBirth.Value = competitorModel.DateOfBirth;
            cmbBeltColor.SelectedIndex = beltColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            frmCompetitors frm = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private bool ValidateForm()
        {
            if (txtFirstName.Text.Length == 0 || txtLastName.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                return false;
            }
            if (txtDateOfBirth.GetHashCode() == 0 || txtDateOfBirth.Value >= DateTime.Now)
            {
                return false;
            }
            if (cmbBeltColor.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Selected value = 0");
                return false;
            }

            return true;
        }

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete this competitor?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                CompetitorModel model = new CompetitorModel(competitorModel.Id);
                GlobalConfig.Connection.DeleteCompetitor(model);

                //Clears text boxes for the next use
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtDateOfBirth.Value = DateTime.Now;
                cmbBeltColor.SelectedValue = 0;
                MessageBox.Show("Competitor Deleted");

                //Returns to the Competitors form
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
                frmCompetitors frm = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
                frm.Show();
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }
    }
}
