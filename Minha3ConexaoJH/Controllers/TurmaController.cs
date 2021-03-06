using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Minha3ConexaoJH.Data.Repository;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly TurmaRepository repo;

        public TurmaController()
        {
            repo = new TurmaRepository();
        }

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
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
