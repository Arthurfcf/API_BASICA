using API_1.DTOs;
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

        public  ParcipationController(ParticipationRepository participationRepository, Mapper mapper)
        {
            _participationRepository = participationRepository;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody]ParticipationDto participationDto)
        {
            Participation participation = _mapper.Map<Participation>(participationDto);
            var result = await _participationRepository.SaveAsync(participation);
            return Ok(result);
           
        }

        [HttpGet]
        [Route("participation")]
        public async Task<IActionResult> GetParticipationsAsync()
        {
            var result = await _participationRepository.GetParticipationsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParticipationsIdAsync(int id)
        {
            var result = await _participationRepository.GetParticipationsIdAsync(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _participationRepository.DeleteAsync(id);
            return Ok(result);
        }

    }
}
