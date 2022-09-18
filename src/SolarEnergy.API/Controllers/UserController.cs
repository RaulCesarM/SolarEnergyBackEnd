using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SolarEnergy.API.Config;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Interfaces.IServices;

namespace SolarEnergy.API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _usuarioservice;
        private readonly CacheService<UsuarioDTO> _usuarioCache;
        public UserController(IUserService usuarioservice, CacheService<UsuarioDTO> usuarioCache )
        {
            _usuarioservice = usuarioservice;
            _usuarioCache = usuarioCache;

        }

        [HttpGet]
        public IActionResult ObterTodos(int skip = 0, int take = 5)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {

            return Ok();
        }
        [HttpPost]
        public IActionResult Inserir(UsuarioDTO producao)
        {
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UsuarioDTO usuario)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<UsuarioDTO> usuarioPatch)
        {

            var usuarioDB = _usuarioservice.ObterPorId(id);

            usuarioPatch.ApplyTo(usuarioDB, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            usuarioDB.Id = id;
            _usuarioservice.Atualizar(usuarioDB);

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _usuarioservice.Excluir(id);
            _usuarioCache.Remove($"{id}");
            return StatusCode(StatusCodes.Status204NoContent);
        }



    }
}