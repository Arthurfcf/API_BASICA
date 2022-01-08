﻿using API_1.Context;
using API_1.Entidades;
using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Repositories
{
    public class ParticipationRepository : IParticipation
    {
        private readonly Banco1Context _banco1Context;
       
        public ParticipationRepository(Banco1Context context)
        {
            _banco1Context = context;
            
        }

        public void DeleteParticipation(int Id)
        {
            Participation participation = _banco1Context.Participations.Find(Id);
            _banco1Context.Participations.Remove(participation);
        }

        public IEnumerable<Participation> GetParticipation()
        {
            return _banco1Context.Participations.ToList();
        }

        public Participation GetParticipationByID(int Id)
        {
            return _banco1Context.Participations.Find(Id);
        }

        public void InsertParticipation(Participation participation)
        {
            if (participation != null)
            {

                Console.WriteLine("Participante já existente");

            }
            _banco1Context.Participations.Add(participation);
            _banco1Context.SaveChanges();
        }

        public void SaveParticipation(Participation participation)
        {
            throw new NotImplementedException();
        }
    }
}
