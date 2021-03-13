using Minha3ConexaoJH.Domain;
using System.Collections.Generic;

namespace Minha3ConexaoJH.Data.Interface
{
    public interface ITurmaProfessorRepository : IBaseRepository<TurmaProfessor>
    {
        List<TurmaProfessor> SelecionarTudoCompleto();
    }
}
