using API_1.Entidades;
using API_1.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Mappers
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<Participation, ParticipationModel>()
                .ReverseMap();
        }
    }
}
