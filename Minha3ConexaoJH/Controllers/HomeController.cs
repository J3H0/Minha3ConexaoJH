using Microsoft.AspNetCore.Mvc;
using Minha3ConexaoJH.Data.Interface;
using Minha3ConexaoJH.Domain.Model;
using Minha3ConexaoJH.Services;
using System;

namespace Minha3ConexaoJH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUsuarioRepository _usuariorepo;
        public HomeController(IUsuarioRepository usuarioRepo)
        {
            _usuariorepo = usuarioRepo;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] Usuario usuarioDto)
        {
            try
            {
                if (string.IsNullOrEmpty(usuarioDto.Nome) || string.IsNullOrEmpty(usuarioDto.Senha))
                    return BadRequest("Nome e/ou senha não devem ser nulas.");

                var usuario = _usuariorepo.SelecionarPorNomeESenha(usuarioDto.Nome, usuarioDto.Senha);

                if (usuario == null)
                    return NotFound("Nome e/ou Senha inválido(s).");

                var token = TokenService.GerarToken(usuario);

                return Ok(token);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
            
        }
    }
}
