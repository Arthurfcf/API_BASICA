using API_1.DTOs;
using API_1.Entidades;
using API_1.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Mappers
{
    public class DtoModelProfile : Profile
    {
        public DtoModelProfile()
        {
            CreateMap<ParticipationDto, ParticipationModel>()
                .ReverseMap();
            CreateMap<ParticipationDto, Participation>()
                .ReverseMap();

        }
    }
}
