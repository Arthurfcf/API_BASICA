using API_1.Context;
using API_1.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
    public class UsersRepository : IUsers
    {
        private readonly Banco1Context _banco1Context;

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
            Users user = _banco1Context.users.Add(user);
           
        }

        public void SaveUsers(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
