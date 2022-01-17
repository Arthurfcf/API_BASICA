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
    [Controller]
    [Route("controller")]
    public class ParcipationController : ControllerBase
    {
        private readonly IParticipation _participation;
       // private readonly IMapper _mapper;

        public ParcipationController(IParticipation participation)
        {
            _participation = participation;
        }

        
                [HttpPost]
                //objeto de entrada 
                // true ou false 
                public async Task<IActionResult> Save([FromBody]Participation participation)
        {
            return await _participation.Add(participation);
        }


                
        

        // lista de objetos 
        //sem parametros de entrada
        [HttpGet]
        [Route("participation")]
        public async Task<IActionResult> GetAll()
        {
            return 
            var result = await _participation.GetAll();
            return Ok(result);
        }
    


        [HttpGet("{id}")]
        //return objeto 
        // entrar um id 
        public async Task<IActionResult> GetId(int Codigo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
          
                var participation = _participation.Find(Codigo);
                return participation
           
        }

        //true ou false
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _participation.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }

    
}