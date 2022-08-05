using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolarEnergyBackEnd.Contextos;
using SolarEnergyBackEnd.Models;

namespace SolarEnergyBackEnd.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : ControllerBase {


        private readonly UnidadesContexto _contexto;
        public RegistroController(UnidadesContexto contexto) {
            _contexto = contexto;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registro>>> PegarTodosAsync() {
            
            return await _contexto.Registros.ToListAsync();
        }
        [HttpGet("{IdRegistro}")]
        public async Task<ActionResult<Registro>> PegarRegistroPeloIdAsync(int IdRegistro) {
            Registro registro = await _contexto.Registros.FindAsync(IdRegistro);
            if (registro == null) {
                return NotFound();
            }
            return registro;
        }
        [HttpPost]
        public async Task<ActionResult<Registro>> SalvarPessoaAsync(Registro unidade) {
            await _contexto.Registros.AddAsync(unidade);
            await _contexto.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> AtualizarRegistroAsync(Registro unidade) {
            _contexto.Registros.Update(unidade);
            await _contexto.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{IdRegistro}")]
        public async Task<ActionResult> DeletarRegistroAsync(int IdRegistro) {
            Registro registro = await _contexto.Registros.FindAsync(IdRegistro);
            if (registro == null) {

                return NotFound();

            } else {
                _contexto.Remove(registro);
                await _contexto.SaveChangesAsync();
                return Ok();

            }


        }
    }
}
