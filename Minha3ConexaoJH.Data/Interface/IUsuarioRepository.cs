using Minha3ConexaoJH.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha3ConexaoJH.Data.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario SelecionarPorNomeESenha(string nome, string senha);
    }
}
