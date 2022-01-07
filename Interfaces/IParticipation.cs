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
        IEnumerable<Participation> GetParticipation();
        Participation GetParticipationByID(int Id);
        void InsertParticipation(Participation participation);
        void DeleteParticipation(int Id);
        void SaveParticipation(Participation participation);
    }
}
