using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Minha3ConexaoJH.Data.Repository;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository repo;

        public AlunoController()
        {
            repo = new AlunoRepository();
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] Aluno aluno)
        {
            repo.Incluir(aluno);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Aluno> Put([FromBody] Aluno aluno)
        {
            repo.Alterar(aluno);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Aluno> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
