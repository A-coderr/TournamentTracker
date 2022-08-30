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
    public partial class UDTournament : Form
    {
        public UDTournament()
        {
            InitializeComponent();
        }

        private void btnUpdateT_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentModel model = new TournamentModel(MainDashboard.mainDashboardInstance.tournament.Id, txtTournamentName.Text, txtTournamentDate.Value);
                GlobalConfig.Connection.UpdateTournament(model);
                MainDashboard.mainDashboardInstance.tournament.Name = txtTournamentName.Text;
                MainDashboard.mainDashboardInstance.tournament.Date = txtTournamentDate.Value;
                MainDashboard.mainDashboardInstance.tName.Text = txtTournamentName.Text;

                MessageBox.Show("Tournament Updated");
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

        private void UDTournament_Load(object sender, EventArgs e)
        {
            txtTournamentName.Text = MainDashboard.mainDashboardInstance.tournament.Name;
            txtTournamentDate.Value = MainDashboard.mainDashboardInstance.tournament.Date;
        }
    }
}
