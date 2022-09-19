using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class DivisionModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Type { get; set; }

        public int TournamentId { get; set; }

        public bool DivisionClosed { get; set; }

        public List<CompetitorModel> EnteredCompetitors { get; set; } = new List<CompetitorModel>();
        public List<CompetitorModel> CompetitorsToRemove { get; set; } = new List<CompetitorModel>();
        public List<MatchModel> GeneratedMatches { get; set; } = new List<MatchModel>();

        //public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public DivisionModel()
        {
        }

        public DivisionModel(int id)
        {
            Id = id;
        }

        public DivisionModel(string name, int type, int tournamentId, bool divisionClosed, List<CompetitorModel> enteredCompetitors)
        {
            Name = name;
            Type = type;
            TournamentId = tournamentId;
            DivisionClosed = divisionClosed;
            EnteredCompetitors = enteredCompetitors;
        }

        public DivisionModel(int id, string name, int type, int tournamentId, bool divisionClosed, List<CompetitorModel> enteredCompetitors, List<CompetitorModel> competitorsToRemove)
        {
            Id = id;
            Name = name;
            Type = type;
            TournamentId = tournamentId;
            DivisionClosed = divisionClosed;
            EnteredCompetitors = enteredCompetitors;
            CompetitorsToRemove = competitorsToRemove;
        }
    }
}
