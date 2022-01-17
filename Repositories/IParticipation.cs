using API_1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
  public  interface IParticipation
    {
        Participation Find(int Codigo);
        List<Participation> GetAll();
        Participation Add(Participation participation);
        void Remove(int Codigo);

    }
}
