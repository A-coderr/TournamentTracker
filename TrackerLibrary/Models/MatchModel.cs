using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchModel
    {
        public int Id { get; set; }
        public int ParentMatchId { get; set; }
        public int DivisionId { get; set; }
        public int WinnerId { get; set; }
        public int Competitor1Id { get; set; }
        public int Competitor2Id { get; set; }
        public int Competitor1Score { get; set; }
        public int Competitor2Score { get; set; }
        public bool MatchDone { get; set; }

        public List<CompetitorModel> EnteredCompetitorsForThisMatch { get; set; } = new List<CompetitorModel>();
    }
}
