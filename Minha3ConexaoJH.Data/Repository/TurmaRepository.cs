using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(Context context) : base(context)
        {
           
        }
    }
}
