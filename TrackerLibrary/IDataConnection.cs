using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public interface IDataConnection
    {
        TournamentModel CreateTournament(TournamentModel model);
        CompetitorModel CreateCompetitor(CompetitorModel model);
        CompetitorModel UpdateCompetitor(CompetitorModel model);
        CompetitorModel DeleteCompetitor(CompetitorModel model);
        void CreateDivision(DivisionModel model);
        List<CompetitorModel> GetCompetitor_All();
        List<CompetitorModel> GetCompetitor_ByTournament(int tournamentId);
        List<TournamentModel> GetTournaments_All();
    }
}
