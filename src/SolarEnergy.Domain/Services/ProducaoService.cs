

using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Interfaces.IServices;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Domain.Services
{
    public class ProducaoService : IProducaoService
    {
        public void Atualizar(ProducaoDTO producao)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(ProducaoDTO producao)
        {
            throw new NotImplementedException();
        }

        public ProducaoDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProducaoDTO> ObterTodos(Paginacao paginacao)
        {
            throw new NotImplementedException();
        }

        public int ObterTotal()
        {
            throw new NotImplementedException();
        }
    }
}