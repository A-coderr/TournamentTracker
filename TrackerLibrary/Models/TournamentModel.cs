using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<DivisionModel> Divisions { get; set; } = new List<DivisionModel>();
        public List<CompetitorModel> Competitors { get; set; } = new List<CompetitorModel>();

        public TournamentModel()
        {
        }

        public TournamentModel(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public TournamentModel(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Date = date;
        }

        public TournamentModel(int id)
        {
            Id = id;
        }
    }
}
