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
        Task<List<Users>> GetUsersAsync();
        Task<Users> GetUsersIdAsync(int id);
        Task<int> SaveAsync(Users users);
        Task<int> DeleteAsync(int id);
    }
}
