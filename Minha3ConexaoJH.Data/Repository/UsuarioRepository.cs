using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain.Model;
using System.Linq;

namespace Minha3ConexaoJH.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context)
        { 

        }

        public Usuario SelecionarPorNomeESenha(string nome, string senha)
        {
            return _context.Set<Usuario>().FirstOrDefault(u => u.Nome == nome && u.Senha == senha);
        }
    }
}
