using System.Collections.Generic;
using System.Linq;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class ProfessorRepository
    {
        private readonly Context context;

        public ProfessorRepository()
        {
            context = new Context();
        }

        public void Incluir(Professor prof)
        {
            context.Professor.Add(prof);
            context.SaveChanges();
        }

        public Professor Selecionar(int id)
        {
            return context.Professor.FirstOrDefault(a => a.Id == id);
        }

        public List<Professor> SelecionarTudo()
        {
            return context.Professor.ToList();
        }

        public void Alterar(Professor prof)
        {
            context.Professor.Update(prof);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var prof = Selecionar(id);
            context.Professor.Remove(prof);
        }
    }
}
