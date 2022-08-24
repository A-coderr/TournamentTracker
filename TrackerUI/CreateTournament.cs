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
    public partial class CreateTournament : Form
    {
        public CreateTournament()
        {
            InitializeComponent();
        }

        private void btnCreateT_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentModel model = new TournamentModel(txtTournamentName.Text, txtTournamentDate.Value);
                GlobalConfig.Connection.CreateTournament(model);

                txtTournamentName.Text = "";
                txtTournamentDate.Value = DateTime.Now;
                //MainDashboard mainDashboard = new MainDashboard();
                //mainDashboard.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Form is Invalid");
            }
        }

        private bool ValidateForm()
        {
            if (txtTournamentName.Text.Length == 0)
            {
                return false;
            }
            if (txtTournamentDate.GetHashCode() == 0 || txtTournamentDate.Value < DateTime.Now)
            {
                return false;
            }

            return true;
        }
    }
}
