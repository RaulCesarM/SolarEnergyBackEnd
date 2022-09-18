
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Domain.Interfaces.IServices
{
    public interface IUnidadeService
    {
        IList<UnidadeDTO> ObterTodos(Paginacao paginacao);
        UnidadeDTO ObterPorId(int id);
        void Inserir(UnidadeDTO unidade);
        void Excluir(int id);
        void Atualizar(UnidadeDTO unidade);
        public int ObterTotal();
        
    }
}