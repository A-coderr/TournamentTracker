using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Dapper;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// This class is creating new tournaments
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TournamentModel CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var t = new DynamicParameters();
                t.Add("@TournamentName", model.Name);
                t.Add("@TournamentDate", model.Date);
                t.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournament_Insert", t, commandType: CommandType.StoredProcedure);
                model.Id = t.Get<int>("@id");
                return model;
            }
        }

        public CompetitorModel CreateCompetitor(CompetitorModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@FirstName", model.FirstName);
                c.Add("@LastName", model.LastName);
                c.Add("@Email", model.Email);
                c.Add("@DateOfBirth", model.DateOfBirth);
                c.Add("@BeltColor", model.BeltColor);
                c.Add("@TournamentId", model.TournamentId);
                c.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCompetitor_Insert", c, commandType: CommandType.StoredProcedure);
                model.Id = c.Get<int>("@id");
                return model;
            }
        }
        

        public List<CompetitorModel> GetCompetitor_All()
        {
            List<CompetitorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                output = connection.Query<CompetitorModel>("dbo.spCompetitor_GetAll").ToList();
            }
            return output;
        }

        public List<CompetitorModel> GetCompetitor_ByTournament(int tournamentId)
        {
            List<CompetitorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var p = new DynamicParameters();
                p = new DynamicParameters();
                p.Add("@TournamentId", tournamentId);
                output = connection.Query<CompetitorModel>("dbo.spCompetitor_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<CompetitorModel> GetCompetitor_ByDivision(int divisionId)
        {
            List<CompetitorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var p = new DynamicParameters();
                p = new DynamicParameters();
                p.Add("@DivisionId", divisionId);
                output = connection.Query<CompetitorModel>("dbo.spCompetitor_GetByDivision", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<TournamentModel> GetTournaments_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                //output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                output = connection.Query<TournamentModel>($"SELECT * FROM Tournament").ToList();
                var p = new DynamicParameters();

                foreach (TournamentModel tournamentModel in output)
                {
                    //Populate Competitors
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournamentModel.Id);
                    tournamentModel.Competitors = connection.Query<CompetitorModel>("dbo.spCompetitor_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    //Populate Divisions
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournamentModel.Id);
                    tournamentModel.Divisions = connection.Query<DivisionModel>("dbo.spDivision_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (DivisionModel divisionModel in tournamentModel.Divisions)
                    {
                        var c = new DynamicParameters();
                        c.Add("@DivisionId", divisionModel.Id);
                        divisionModel.EnteredCompetitors = connection.Query<CompetitorModel>("dbo.spCompetitor_GetByDivision", c, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
            }
            return output;
        }

        public void CreateDivision(DivisionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@Name", model.Name);
                c.Add("@TournamentId", model.TournamentId);
                c.Add("@Type", model.Type);
                c.Add("@DivisionClosed", model.DivisionClosed);
                c.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDivision_Insert", c, commandType: CommandType.StoredProcedure);
                model.Id = c.Get<int>("@id");

                foreach(CompetitorModel competitorModel in model.EnteredCompetitors)
                {
                    c = new DynamicParameters();
                    c.Add("@DivisionId", model.Id);
                    c.Add("@CompetitorId", competitorModel.Id);
                    c.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spDivisionEntries_Insert", c, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public CompetitorModel UpdateCompetitor(CompetitorModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@FirstName", model.FirstName);
                c.Add("@LastName", model.LastName);
                c.Add("@Email", model.Email);
                c.Add("@DateOfBirth", model.DateOfBirth);
                c.Add("@BeltColor", model.BeltColor);
                c.Add("@TournamentId", model.TournamentId);
                c.Add("@id", model.Id);

                connection.Execute("dbo.spCompetitor_Update", c, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public CompetitorModel DeleteCompetitor(CompetitorModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@id", model.Id);

                connection.Execute("dbo.spCompetitor_Delete", c, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public TournamentModel UpdateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var t = new DynamicParameters();
                t.Add("@TournamentName", model.Name);
                t.Add("@TournamentDate", model.Date);
                t.Add("@id", model.Id);

                connection.Execute("dbo.spTournament_Update", t, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public List<DivisionTypeModel> GetDivisionType_All()
        {
            List<DivisionTypeModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                output = connection.Query<DivisionTypeModel>("dbo.spDivisionType_GetAll").ToList();
            }
            return output;
        }

        public DivisionModel UpdateDivision(DivisionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@Name", model.Name);
                c.Add("@TournamentId", model.TournamentId);
                c.Add("@Type", model.Type);
                c.Add("@DivisionClosed", model.DivisionClosed);
                c.Add("@id", model.Id);

                connection.Execute("dbo.spDivision_Update", c, commandType: CommandType.StoredProcedure);

                foreach (CompetitorModel competitorModel in model.EnteredCompetitors)
                {
                    c = new DynamicParameters();
                    c.Add("@DivisionId", model.Id);
                    c.Add("@CompetitorId", competitorModel.Id);
                    c.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spDivisionEntries_Insert", c, commandType: CommandType.StoredProcedure);
                }

                foreach (CompetitorModel competitorModel in model.CompetitorsToRemove)
                {
                    c = new DynamicParameters();
                    c.Add("@DivisionId", model.Id);
                    c.Add("@CompetitorId", competitorModel.Id);

                    connection.Execute("dbo.spDivisionEntries_Remove", c, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
            
        }

        public DivisionModel DeleteDivision(DivisionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var c = new DynamicParameters();
                c.Add("@id", model.Id);

                connection.Execute("dbo.spDivision_Delete", c, commandType: CommandType.StoredProcedure);

                foreach (CompetitorModel competitorModel in model.EnteredCompetitors)
                {
                    c = new DynamicParameters();
                    c.Add("@DivisionId", model.Id);
                    c.Add("@CompetitorId", competitorModel.Id);

                    connection.Execute("dbo.spDivisionEntries_Remove", c, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        public List<DivisionModel> GetDivision_ByTournament(int tournamentId)
        {
            List<DivisionModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("DatabaseConnection")))
            {
                var p = new DynamicParameters();
                p = new DynamicParameters();
                p.Add("@TournamentId", tournamentId);
                output = connection.Query<DivisionModel>("dbo.spDivision_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }
    }
}
