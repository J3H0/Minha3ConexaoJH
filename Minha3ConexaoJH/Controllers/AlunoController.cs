using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Minha3ConexaoJH.Data.Repository;
using Minha3ConexaoJH.Domain;
using Minha3ConexaoJH.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _repo;

        public AlunoController(IAlunoRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Retorna um aluno pelo Id. 
        /// </summary>
        /// <param name="id">Identificador do aluno.</param>
        /// <returns>Mais uma descrição.</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///      Get/api/aluno/1
        ///      
        /// </remarks>
        /// <response code="200">Retorna o aluno com identificador informado</response>
        /// <response code="400">Se acontecer alguma exceção não tratada.</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Authorize(Roles = "marketing")]

        public IActionResult Get()
        {
            try
            {
                 return Ok(_repo.SelecionarTudo());
            }
            catch(System.Exception)
            {
                return StatusCode(500);
                //return BadRequest("Acontceu um erro");
            }
           
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] Aluno aluno)
        {
            _repo.Incluir(aluno);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Aluno> Put([FromBody] Aluno aluno)
        {
            _repo.Alterar(aluno);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Aluno> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTudo();
        }
    }
}
