using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Minha3ConexaoJH.Domain;
using Minha3ConexaoJH.Data.Interface;
using Microsoft.Extensions.Logging;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaRepository repo;
        private readonly ILogger _logger;

        public TurmaController(ITurmaRepository turmaRepository, ILogger<TurmaController> logger)
        {
            repo = turmaRepository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            try 
            {
                throw new System.Exception();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Erro ao recuperar todas as Turmas");
            }
            return repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] Turma turma)
        {
            repo.Incluir(turma);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Turma> Put([FromBody] Turma turma)
        {
            repo.Alterar(turma);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Turma> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
