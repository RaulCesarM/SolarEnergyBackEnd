using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SolarEnergy.API.Config;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Interfaces.IServices;

namespace SolarEnergy.API.Controllers
{
    [ApiController]
    [Route("api/unidade")]
    public class UnidadesController : ControllerBase
    {
        private readonly IUnidadeService _unidadeservice;
        private readonly CacheService<UnidadeDTO> _unidadeCache;
        public UnidadesController(IUnidadeService unidadeservice, CacheService<UnidadeDTO> unidadeCache )
        {
              _unidadeservice = unidadeservice;
            _unidadeCache = unidadeCache;
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
        public IActionResult Inserir(UnidadeDTO unidade)
        {
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UnidadeDTO unidade)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<UnidadeDTO> unidadePatch)
        {

            var unidadeDB = _unidadeservice.ObterPorId(id);// criar serviço

            unidadePatch.ApplyTo(unidadeDB, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            unidadeDB.Id = id;
            _unidadeservice.Atualizar(unidadeDB);

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _unidadeservice.Excluir(id);
            _unidadeCache.Remove($"{id}");
            return StatusCode(StatusCodes.Status204NoContent);
        }



    }
}