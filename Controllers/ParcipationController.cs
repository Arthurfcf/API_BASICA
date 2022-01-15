using API_1.DTOs;
using API_1.Entidades;
using API_1.Repositories;
using API_1.Services;
using API_1.Servicos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace API_1.Controllers
{
    //Usar Dapper 
    //Deixar o Dto
    //Mudar o nome dos métodos  
    //Padrão Save, Delete  e Get 
    //Classe nome Participation + Objetivo Service ou Repo ex
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
        //objeto de entrada 
        // true ou false 
        public async Task<IActionResult> SaveAsync([FromBody]ParticipationDto participationDto)
        {
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           try
            {
                Participation participation = _mapper.Map<Participation>(participationDto);
                var result = await _service.Save(participation);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
                
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // lista de objetos 
        //sem parametros de entrada
        [HttpGet]
        [Route("participation")]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetAll());

            }catch(ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

           
        }

        [HttpGet("{id}")]
        //return objeto 
        // entrar um id 
        public async Task<IActionResult> GetAll(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        //true ou false
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }

    
}
