using System.Collections.Generic;
using System.Linq;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class TurmaProfessorRepository
    {
        private readonly Context context;

        public TurmaProfessorRepository()
        {
            context = new Context();
        }

        public void Incluir(TurmaProfessor tp)
        {
            context.TurmaProfessor.Add(tp);
            context.SaveChanges();
        }

        public TurmaProfessor Selecionar(int id)
        {
            return context.TurmaProfessor.FirstOrDefault(x => x.Id == id);
        }

        public List<TurmaProfessor> SelecionarTudo()
        {
            return context.TurmaProfessor.ToList();
        }

        public void Alterar(TurmaProfessor tp)
        {
            context.TurmaProfessor.Update(tp);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var tp = Selecionar(id);
            context.TurmaProfessor.Remove(tp);
            context.SaveChanges();
        }
    }
}
