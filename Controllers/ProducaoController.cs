using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolarEnergyBackEnd.Contextos;
using SolarEnergyBackEnd.Models;

namespace SolarEnergyBackEnd.Controllers {
    [ApiController]
    [Route("api/[controller]")]    
    public class ProducaoController : ControllerBase {



        private readonly UnidadesContexto _contexto;
        public ProducaoController(UnidadesContexto contexto) {
            _contexto = contexto;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producao>>> PegarTodosAsync() {
            return await _contexto.Producaos.ToListAsync();
        }

        [HttpGet("{IdProducao}")]
        public async Task<ActionResult<Producao>> PegarProducaoPeloIdAsync(int IdProducao) {
            Producao unidade = await _contexto.Producaos.FindAsync(IdProducao);
            if (unidade == null) {
                return NotFound();
            }
            return unidade;
        }
        [HttpPost]
        public async Task<ActionResult<Unidade>> SalvarProducaoAsync(Producao producao) {
            await _contexto.Producaos.AddAsync(producao);
            await _contexto.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> AtualizarProducaoAsync(Producao producao) {
            _contexto.Producaos.Update(producao);
            await _contexto.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{IdProducao}")]
        public async Task<ActionResult> DeletarProducaoAsync(int IdProducao) {
            Producao producao = await _contexto.Producaos.FindAsync(IdProducao);
            if (producao == null) {

                return NotFound();

            } else {
                _contexto.Remove(producao);
                await _contexto.SaveChangesAsync();
                return Ok();

            }


        }











    }
}
