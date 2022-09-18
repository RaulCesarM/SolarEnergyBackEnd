

using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SolarEnergy.API.Config;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Interfaces.IServices;

namespace SolarEnergy.API.Controllers
{
    [ApiController]
    [Route("api/registro")]
    public class RegistroController: ControllerBase
    {


        private readonly IRegistroService _registroservice;
        private readonly CacheService<RegistroDTO> _registroCache;
        public RegistroController(IRegistroService registroservice, CacheService<RegistroDTO> registroCache )
        {
          _registroservice = registroservice;
            _registroCache = registroCache;
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
        public IActionResult Inserir(RegistroDTO registro)
        {
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] RegistroDTO registro)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int ano, [FromBody] 
        JsonPatchDocument<RegistroDTO> registroPatch)
        {

            var registroDB = _registroservice.ObterPorAno(ano);

            registroPatch.ApplyTo(registroDB, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            registroDB.Ano = ano;
            _registroservice.Atualizar(registroDB);

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int ano)
        {
            _registroservice.Excluir(ano);
            _registroCache.Remove($"{ano}");
            return StatusCode(StatusCodes.Status204NoContent);
        }



    }
}