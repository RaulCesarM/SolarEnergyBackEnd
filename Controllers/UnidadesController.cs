using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolarEnergyBackEnd.Contextos;
using SolarEnergyBackEnd.Models;

namespace SolarEnergyBackEnd.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadesController : ControllerBase {


        private readonly UnidadesContexto _contexto;
        public UnidadesController(UnidadesContexto contexto) {
            _contexto = contexto;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unidade>>> PegarTodosAsync() {
            return await _contexto.Unidades.ToListAsync();
        }
        [HttpGet("{IdUnidade}")]
        public async Task<ActionResult<Unidade>> PegarUnidadePeloIdAsync(int IdUnidade) {
            Unidade unidade = await _contexto.Unidades.FindAsync(IdUnidade);
            if (unidade == null) {
                return NotFound();
            }
            return unidade;
        }
        [HttpPost]
        public async Task<ActionResult<Unidade>> SalvarUnidadeAsync(Unidade unidade) {
            await _contexto.Unidades.AddAsync(unidade);
            await _contexto.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> AtualizarUnidadeAsync(Unidade unidade) {
            _contexto.Unidades.Update(unidade);
            await _contexto.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{IdUnidade}")]
        public async Task<ActionResult> DeletarUnidadeAsync(int IdUnidade) {
            Unidade unidade = await _contexto.Unidades.FindAsync(IdUnidade);
            if (unidade == null) {

                return NotFound();

            } else {
                _contexto.Remove(unidade);
                await _contexto.SaveChangesAsync();
                return Ok();

            }


        }

    }
}
