﻿using API_1.DTOs;
using API_1.Entidades;
using API_1.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Controllers
{
    [Controller][Route("controller")]
    public class ParcipationController : ControllerBase
    {
        private ParticipationRepository _participationRepository;
        private IMapper _mapper;

        public ParcipationController(ParticipationRepository participationRepository, Mapper mapper)
        {
            _participationRepository = participationRepository;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult Adicionar([FromBody]ParticipationDto participationDto)
        {
            Participation participation = _mapper.Map<Participation>(participationDto);
            _participationRepository.SaveParticipation(participation);

            return Ok(participation); 
        }

        [HttpGet]
        public IEnumerable<ParticipationRepository> Listagem()
        {
            return (IEnumerable<ParticipationRepository>)_participationRepository.GetParticipation();
        }

        [HttpGet("{id}")]
        public IAsyncResult ListagemPorId()
        {
            Participation participation = _participationRepository.GetParticipationByID();
            return Ok();
        }
        [HttpDelete]

       
    }
}
