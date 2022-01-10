using API_1.DTOs;
using API_1.Entidades;
using API_1.Repositories;
using API_1.Servicos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_1.Controllers
{
    [Controller][Route("controller")]
    public class ParcipationController : ControllerBase
    {
        private readonly Service _service;
        private readonly IMapper _mapper;

        public  ParcipationController(Service service , Mapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> SaveAsync([FromBody]ParticipationDto participationDto)
        {
            Participation participation = _mapper.Map<Participation>(participationDto);
            var result = await _service.Post(participation);
            return Ok(result);
           
        }

        [HttpGet]
        [Route("participation")]
        public async Task<IActionResult> GetParticipationsAsync()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParticipationsIdAsync(int id)
        {
            var result = await _service.Get(id);

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _service.Delete(id);
            return Ok(result);
        }

    }
}
