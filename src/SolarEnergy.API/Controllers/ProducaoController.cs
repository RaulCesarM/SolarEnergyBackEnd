using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SolarEnergy.API.Config;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Interfaces.IServices;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.API.Controllers
{
    [ApiController]
    [Route("api/producao")]
    public class ProducaoController : ControllerBase
    {
        private readonly IProducaoService _prodservice;
        private readonly CacheService<ProducaoDTO> _producaoCache;
        public ProducaoController(IProducaoService prodservice,CacheService<ProducaoDTO> producaoCache )
        {
            _prodservice = prodservice;
            _producaoCache = producaoCache;
        }

        [HttpGet]
        public IActionResult ObterTodos(int skip = 0, int take = 5)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
           
            return Ok();
        }
        [HttpPost]
        public IActionResult Inserir(ProducaoDTO producao)
        {
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] ProducaoDTO producao)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<ProducaoDTO> prodPatch)
        {

            var prodDB = _prodservice.ObterPorId(id);

            prodPatch.ApplyTo(prodDB, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prodDB.id = id;
            _prodservice.Atualizar(prodDB);

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _prodservice.Excluir(id);
            _producaoCache.Remove($"{id}");
            return StatusCode(StatusCodes.Status204NoContent);
        }
      

        
    }
}