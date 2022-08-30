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
    public partial class CreateCompetitor : Form
    {
        public CreateCompetitor()
        {
            InitializeComponent();          
        }

        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CompetitorModel model = new CompetitorModel(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtDateOfBirth.Value, cmbBeltColor.Text, MainDashboard.mainDashboardInstance.tournament.Id);
                GlobalConfig.Connection.CreateCompetitor(model);

                //Adds competitor to Tournament Instance
                MainDashboard.mainDashboardInstance.tournament.Competitors.Add(model);

                //Clears text boxes for the next use
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtDateOfBirth.Value = DateTime.Now;
                cmbBeltColor.SelectedValue = 0;
               
                MessageBox.Show("Competitor Added");

                //Returns to the Competitors form
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
                frmCompetitors frmCompetitors = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmCompetitors.FormBorderStyle = FormBorderStyle.None;
                MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frmCompetitors);
                frmCompetitors.Show();
            }
            else
            {
                MessageBox.Show("Form is Invalid");
            }
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

        private void CreateCompetitor_Load(object sender, EventArgs e)
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
        }

        private void txtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBeltColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
