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
        public TournamentModel tournament;
        public MainDashboard(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
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
            lblTournamentName.Text = tournament.Id.ToString();
        }

        private void btnCompetitors_Click(object sender, EventArgs e)
        {
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
            btnTracker.BackColor = Color.FromArgb(25, 33, 61);
            lblTitle.Text = "Tracker";
            this.pnlFormLoader.Controls.Clear();
            frmTracker frmTracker = new frmTracker() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTracker.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmTracker);
            frmTracker.Show();
        }

        private void btnCompetitors_Leave(object sender, EventArgs e)
        {
            btnCompetitors.BackColor = Color.FromArgb(26, 26, 54);
        }

        private void btnDivisions_Leave(object sender, EventArgs e)
        {
            btnDivisions.BackColor = Color.FromArgb(26, 26, 54);
        }

        private void btnGenerator_Leave(object sender, EventArgs e)
        {
            btnGenerator.BackColor = Color.FromArgb(26, 26, 54);
        }

        private void btnTracker_Leave(object sender, EventArgs e)
        {
            btnCompetitors.BackColor = Color.FromArgb(26, 26, 54);
        }
    }
}
