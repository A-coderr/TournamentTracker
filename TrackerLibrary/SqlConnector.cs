﻿using System;
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
                c.Add("@EmailAddress", model.Email);
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

        
    }
}