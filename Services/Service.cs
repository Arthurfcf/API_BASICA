using API_1.Entidades;
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
        public async Task<int> Delete(int Codigo)
        {
            if ( Codigo >= 2)
            {
                return 0;
            }
            int result = Codigo;
                return await _repository.Delete(result);        
           
        }

        public async Task<Participation> Get(int Codigo)
        {
            return await _repository.GetId(Codigo);
        }

        public async Task<IEnumerable<Participation>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Participation participation)
        {
            if (participation == null)
            {
                await _repository.Save(participation);
                int result = participation;
                return result;  
            }
            return 0;

        }

       
    }
}
