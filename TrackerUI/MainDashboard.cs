using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class MainDashboard : Form
    {
        public static MainDashboard mainDashboardInstance;
        public Panel mainPanel;
        public Label tName;
        public TournamentModel tournament;
        public MainDashboard(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            tName = lblTournamentName;
            LoadFormData();

            mainDashboardInstance = this;
            mainPanel = pnlFormLoader;
            btnCompetitors.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Competitors";
            this.pnlFormLoader.Controls.Clear();
            frmCompetitors frmCompetitors = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCompetitors.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmCompetitors);
            frmCompetitors.Show();
        }

        private void LoadFormData()
        {
            tName.Text = tournament.Name;
        }

        private void btnCompetitors_Click(object sender, EventArgs e)
        {
            buttonsDeactivated();
            btnCompetitors.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Competitors";
            this.pnlFormLoader.Controls.Clear();
            frmCompetitors frmCompetitors = new frmCompetitors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCompetitors.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmCompetitors);
            frmCompetitors.Show();

        }

        private void btnDivisions_Click(object sender, EventArgs e)
        {
            buttonsDeactivated();
            btnDivisions.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Divisions";
            this.pnlFormLoader.Controls.Clear();
            frmDivisions frmDivisions = new frmDivisions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDivisions.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDivisions);
            frmDivisions.Show();
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            buttonsDeactivated();
            btnGenerator.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Generator";
            this.pnlFormLoader.Controls.Clear();
            frmGenerator frmGenerator = new frmGenerator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGenerator.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmGenerator);
            frmGenerator.Show();
        }

        private void btnTracker_Click(object sender, EventArgs e)
        {
            buttonsDeactivated();
            btnTracker.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Tracker";
            this.pnlFormLoader.Controls.Clear();
            frmTracker frmTracker = new frmTracker() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTracker.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmTracker);
            frmTracker.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            buttonsDeactivated();
            btnSettings.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();
            UDTournament ud = new UDTournament() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ud.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(ud);
            ud.Show();
        }

        private void buttonsDeactivated()
        {
            btnGenerator.BackColor = Color.FromArgb(26, 26, 54);
            btnTracker.BackColor = Color.FromArgb(26, 26, 54);
            btnCompetitors.BackColor = Color.FromArgb(26, 26, 54);
            btnDivisions.BackColor = Color.FromArgb(26, 26, 54);
            btnSettings.BackColor = Color.FromArgb(26, 26, 54);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }
    }
}
