using System.Collections.Generic;
using System.Linq;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class AlunoRepository
    {
        private readonly Context context;

        public AlunoRepository()
        {
            context = new Context();
        }

        public void Incluir(Aluno aluno)
        {
            context.Aluno.Add(aluno);
            context.SaveChanges();
        }

        public Aluno Selecionar(int id)
        {
            return context.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public List<Aluno> SelecionarTudo()
        {
            return context.Aluno.ToList();
        }

        public void Alterar(Aluno aluno)
        {
            context.Aluno.Update(aluno);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var aluno = Selecionar(id);
            context.Aluno.Remove(aluno);
        }
    }
}
