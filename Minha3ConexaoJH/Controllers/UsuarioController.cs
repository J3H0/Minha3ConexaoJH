using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepo;
        public UsuarioController(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Senha))
                    return BadRequest("Usuário não informou Nome ou Senha");

                _usuarioRepo.Incluir(usuario);
                return Ok("Usuário salvo com sucesso.");
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
