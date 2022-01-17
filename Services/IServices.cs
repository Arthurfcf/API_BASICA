using API_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Services
{
    public interface IServices
    {
        Task<Participation> Get(int id);
         
        Task<IEnumerable<Participation>> GetAll();

        Task<int> Save(Participation participation);

        Task<int> Delete (int id);
    }
}
