using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class TurmaProfessorRepository : BaseRepository<TurmaProfessor>
    {
        public List<TurmaProfessor> SelecionarTudoCompleto()
        {
            return context.TurmaProfessor
                .Include(x => x.Professor)
                .Include(x => x.Turma)
                .ToList();
        }

        public override void Incluir(TurmaProfessor entity)
        {
            //regras para a inclusao
            base.Incluir(entity);
        }
    }
}
