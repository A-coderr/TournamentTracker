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
        DivisionModel GetDivisionModel(int divisionId);
        CompetitorModel CreateCompetitor(CompetitorModel model);
        CompetitorModel UpdateCompetitor(CompetitorModel model);
        CompetitorModel DeleteCompetitor(CompetitorModel model);
        TournamentModel UpdateTournament(TournamentModel model);
        void CreateDivision(DivisionModel model);
        void CreateMatches(List<MatchModel> matches);
        DivisionModel UpdateDivision(DivisionModel model);
        DivisionModel DeleteDivision(DivisionModel model);
        List<CompetitorModel> GetCompetitor_All();
        List<DivisionTypeModel> GetDivisionType_All();
        List<DivisionModel> GetDivision_ByTournament(int tournamentId);
        List<CompetitorModel> GetCompetitor_ByTournament(int tournamentId);
        List<CompetitorModel> GetCompetitor_ByDivision(int divisionId);
        List<TournamentModel> GetTournaments_All();
    }
}
