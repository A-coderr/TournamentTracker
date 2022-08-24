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
using System.Drawing.Drawing2D;

namespace TrackerUI
{
    public partial class TournamentDashboard : Form
    {
        List<TournamentModel> availableTournaments = GlobalConfig.Connection.GetTournaments_All();
        public TournamentDashboard()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {       
            cmbTournaments.DataSource = availableTournaments;
            cmbTournaments.DisplayMember = "Name";
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            CreateTournament createTournament = new CreateTournament();
            createTournament.Show();
            this.Hide();
        }

        private void btnLoadTournament_Click(object sender, EventArgs e)
        {
            TournamentModel tournamentModel = (TournamentModel)cmbTournaments.SelectedItem;
            MainDashboard mainDashboard = new MainDashboard(tournamentModel);
            mainDashboard.Show();
            this.Hide();
        }

        private void TournamentDashboard_Load(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
