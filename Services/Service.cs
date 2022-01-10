﻿using API_1.Entidades;
using API_1.Repositories;
using API_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Servicos
{
    public class Service : IServices
        
    {
        private readonly ParticipationRepository _repository;
        public Service(ParticipationRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Participation> Get(int id)
        {
            return await _repository.GetParticipationsIdAsync(id);
        }

        public async Task<IEnumerable<Participation>> GetAll()
        {
            return await _repository.GetParticipationsAsync();
        }

        public async Task<Participation> Post(Participation participation)
        {
            return null;
        }

     
    }
}
