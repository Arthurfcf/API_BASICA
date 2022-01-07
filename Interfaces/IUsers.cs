using API_1.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
    interface IUsers
    {

        IEnumerable GetUsers();
        Users GetUsersByID(int Id);
        void InsertUsers(Users users);
        void DeleteUsers(int Id);
        void SaveUsers(Users users);
    }
}
