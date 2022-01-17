using API_1.Context;
using API_1.DTOs;
using API_1.Entidades;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{


    public class ParticipationRepository : IParticipation

    {


        private readonly IDbConnection _db;
        public ParticipationRepository(IConfiguration configuration)
        {
            this._db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));

        }

        public Participation Add(Participation participation)
        {
            string command = @"INSERT INTO Participation(FirstName, LastName, Value)
                                VALUES(@firstName, @lastName, @value);"
                                 + "SELECT CAST(SCOPE_IDENTITY() as int)";

            var Codigo = _db.Query<int>(command, new
            {
               participation.FirstName,
               participation.LastName,
               participation.Value
            }).Single();
            participation.Codigo = Codigo;
            // participation = await _db.ExecuteAsync(sql: command, param: participation);
            return participation;

        }
/*
        public void Delete(int id)
{
  
   if (id <= 2)
   {
       string command = @"DELETE FROM Participation WHERE Codigo = @id";
       Participation participation = await _db.ExecuteAsync(sql: command, param: new { id });
       return participation;
   }
   return 0;

}
*/
        public Participation Find(int Codigo)
        {
            var sql = "SELECT * FROM Participation WHERE Codigo = @Codigo";
            return _db.Query<Participation>(sql, new { @Codigo = Codigo }).Single();
           
        }

        public List<Participation> GetAll()
        {
            var sql = "SELECT *FROM Participation";
            return _db.Query<Participation>(sql).ToList();
        }


        /*
        public Participation GetId(int Codigo)
        {
           
            var query = "SELECT * FROM Participation WHERE Codigo = @id";
            
            Participation participation = await _db.QueryFirstOrDefaultAsync<Participation>
                (sql: query, param: new { Codigo });
            return participation;
        }
        */
        public void Remove(int Codigo)
        {
            var sql = "DELETE FROM WHERE Codigo = @Codigo";
            _db.Execute(sql, new { @Codigo = Codigo });

        }
        /*
        public async Task<int> Save(Participation participation)
        {

           
                string command = @"INSERT INTO Participation(FirstName, LastName, Value)
                                VALUES(@firstName, @lastName, @value)";
        var Codigo = _db.Query<int>(command, new {
            @firstName = participation.FirstName,
            @lastName = participation.LastName,
            @value = participation.Value });
            participation.Codigo = Codigo;
                // participation = await _db.ExecuteAsync(sql: command, param: participation);
                return  participation;
            
            

        }

        List<Participation> IParticipation.GetAll()
        {
            var sql = "SELECT *FROM Participation";
            return _db.Query<Participation>(sql).ToList();
        }
        */
    }

    }

