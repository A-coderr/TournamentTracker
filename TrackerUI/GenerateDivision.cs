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
    public partial class GenerateDivision : Form
    {
        /// <summary>
        /// I am having bug with regeneration, getting duplicated values
        /// 
        /// Maybe we should also call division model in this class
        /// </summary>
        /// 
        List<MatchModel> generatedMatches = new List<MatchModel>();
        List<CompetitorModel> allComp = new List<CompetitorModel>();
        List<CompetitorModel> generatedComp = new List<CompetitorModel>();
        DivisionModel division = new DivisionModel();
        List<MatchModel> matches = new List<MatchModel>();
        double compNumber = 0;
        double lstNumber = 0;
        public GenerateDivision(DivisionModel model)
        {
            InitializeComponent();
            allComp = GlobalConfig.Connection.GetCompetitor_ByDivision(model.Id);
            division = model;
            compNumber = allComp.Count;
            DivisionModel createdMatches = GlobalConfig.Connection.GetDivisionModel(division.Id);
            generatedMatches = createdMatches.GeneratedMatches;
            if (compNumber%2 == 0)
            {
                lstNumber = compNumber / 2;
            }
            else
            {
                lstNumber = Math.Round(compNumber / 2);
            }

            if(generatedMatches.Count <= 0)
            {
                btnGenerate.Text = "Generate";
                GenerateBrackets(allComp);
            }
            else
            {
                btnGenerate.Text = "Regenerate";
                GenerateBrackets(generatedComp);
            }
            
        }

        private void GenerateBrackets(List<CompetitorModel> competitors)
        {
            int x = 50;
            int y = 50;
            int index = 0;
            matches.Clear();

            //Generate listboxes
            for (int i = 0; i < lstNumber; i++)
            {
                MatchModel match = new MatchModel();
                match.DivisionId = division.Id;
                match.Competitor1Id = competitors[index].Id;
                Label lbl = new Label();
                lbl.Left = x;
                lbl.Top = y;
                lbl.Width = 240;
                lbl.Height = 20;
                lbl.BackColor = Color.Red;
                lbl.Text = competitors[index].FullName;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Tag = "Competitor";
                this.Controls.Add(lbl);
                index++;
                if(index < competitors.Count)
                {
                    match.Competitor2Id = competitors[index].Id;
                    Label lbl1 = new Label();
                    lbl1.Left = x;
                    lbl1.Top = y + lbl.Height;
                    lbl1.Width = 240;
                    lbl1.Height = 20;
                    lbl1.BackColor = Color.Blue;
                    lbl1.Text = competitors[index].FullName;
                    lbl1.TextAlign = ContentAlignment.MiddleLeft;
                    lbl1.Tag = "Competitor";
                    this.Controls.Add(lbl1);
                    index++;
                }              
                matches.Add(match);
                y += 40;              
            }
        }       

        private void GenerateDivision_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<CompetitorModel> NewList = new List<CompetitorModel>();
            NewList = allComp.OrderBy(i => Guid.NewGuid()).ToList();
            foreach (Label lbl in this.Controls.OfType<Label>().Where(x => x.Tag != null && x.Tag.ToString() == "Competitor"))
            {
                this.Controls.Remove(lbl);
            }
            GenerateBrackets(NewList);

        }

        private void GenerateDivision_FormClosing(object sender, FormClosingEventArgs e)
        {           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            frmGenerator frm = new frmGenerator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.CreateMatches(matches);
            MessageBox.Show($"Division was generated!");

            //Returns to the Divisions form
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Clear();
            frmGenerator frm = new frmGenerator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            MainDashboard.mainDashboardInstance.mainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
