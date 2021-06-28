using AutenticacaoApi.Models;
using AutenticacaoApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutenticacaoApi.Controllers
{
    [Route("api/autenticacao")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly ITokenBuilder _tokenBuilder;

        public AutenticacaoController(
            ITokenBuilder tokenBuilder)
        {
            _tokenBuilder = tokenBuilder;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Usuario usuario)
        {
            if (usuario.UsuarioAcesso != "roger.silveira")
            {
                return NotFound("Usuário nõ encontrado.");
            }

            var senhaValida = usuario.Senha == "123456";
            if (!senhaValida)
            {
                return BadRequest("Senha inválida.");
            }

            var token = _tokenBuilder.BuildToken(usuario.UsuarioAcesso);

            return Ok(token);
        }
    }
}
