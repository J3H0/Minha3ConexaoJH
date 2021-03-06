using System.Collections.Generic;
using System.Linq;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class TurmaRepository
    {
        private readonly Context context;

        public TurmaRepository()
        {
            context = new Context();
        }

        public void Incluir(Turma turma)
        {
            context.Turma.Add(turma);
            context.SaveChanges();
        }

        public Turma Selecionar(int id)
        {
            return context.Turma.FirstOrDefault(x => x.Id == id);
        }

        public List<Turma> SelecionarTudo()
        {
            return context.Turma.ToList();
        }

        public void Alterar(Turma turma)
        {
            context.Turma.Update(turma);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var turma = Selecionar(id);
            context.Turma.Remove(turma);
            context.SaveChanges();
        }
    }
}
