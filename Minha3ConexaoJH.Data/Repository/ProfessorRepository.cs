using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(Context context) : base(context)
        {

        }
    }
}

