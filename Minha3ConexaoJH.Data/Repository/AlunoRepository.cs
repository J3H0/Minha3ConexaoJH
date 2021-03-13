using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain;

namespace Minha3ConexaoJH.Data.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(Context context) : base(context)
        {

        }
    }
}

