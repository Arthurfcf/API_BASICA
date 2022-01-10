using API_1.Context;
using API_1.Entidades;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
    public class UsersRepository : IUsers
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

        public async Task<List<Users>> GetUsersAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Participation";
                List<Users> users = (await conn.QueryAsync<Users>(sql: query)).ToList();
                return users;
            }
        }

        public async Task<Users> GetUsersIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Participation WHERE Id = @id";
                Users users = await conn.QueryFirstOrDefaultAsync<Users>
                    (sql: query, param: new { id });
                return users;

            }
        }

        public async Task<int> SaveAsync(Users users)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT INTO Participation(FirstName, LastName, Value)
                                VALUES(@FirstName, @LastName, @Value)";

                var result = await conn.ExecuteAsync(sql: command, param: users);
                return result;
            }
        }
    }
}
        /*private readonly Banco1Context _banco1Context;

        public UsersRepository(Banco1Context context)
        {
            _banco1Context = context;

        }

        public void DeleteUsers(int Id)
        {
            Users users = _banco1Context.users.Find(Id);
            _banco1Context.users.Remove(users);
        }

        public IEnumerable GetUsers()
        {
            return _banco1Context.users.ToList();
        }

        public Users GetUsersByID(int Id)
        {
            return _banco1Context.users.Find(Id);
        }

        public Users GetUSsersByID(int Id)
        {
            throw new NotImplementedException();
        }

        public void InsertUsers(Users users)
        {
             _banco1Context.users.Add(users);
            _banco1Context.SaveChanges();
        }

        public void SaveUsers(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
*/