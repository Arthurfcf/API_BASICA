using API_1.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
    interface IParticipation
    {
        Task<List<Participation>> GetParticipationsAsync();
        Task<Participation> GetParticipationsIdAsync(int id);
        Task<int> SaveAsync(Participation participation);
        Task<int> DeleteAsync(int id);
    }
}
