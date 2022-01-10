using API_1.Context;
using API_1.Entidades;
using AutoMapper;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{

    public class ParticipationRepository : IParticipation

    {

       
        private DbSession _db;
        public async Task<int> DeleteAsync(int id)
        {
           using ( var conn = _db.Connection)
            {
                string command = @"DELETE FROM Participation WHERE Id = @id";
                var result = await conn.ExecuteAsync(sql: command, param: new { id });
                return result;
            }
        }

        public async Task<List<Participation>> GetParticipationsAsync()
        {
           using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Participation";
                List<Participation> participations = (await conn.QueryAsync<Participation>(sql: query)).ToList();
                return participations;
            }
        }

        public async Task<Participation> GetParticipationsIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Participation WHERE Id = @id";
                Participation participation = await conn.QueryFirstOrDefaultAsync<Participation>
                    (sql: query, param: new { id });
                return participation;

            }
        }

        public async Task<int> SaveAsync(Participation participation)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT INTO Participation(FirstName, LastName, Value)
                                VALUES(@FirstName, @LastName, @Value)";

                var result = await conn.ExecuteAsync(sql: command, param: participation);
                return result;
            }
        }
    }
}
