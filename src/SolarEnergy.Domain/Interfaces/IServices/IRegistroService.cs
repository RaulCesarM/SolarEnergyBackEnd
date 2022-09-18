
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Domain.Interfaces.IServices
{
    public interface IRegistroService
    {
        IList<RegistroDTO> ObterTodos(Paginacao paginacao);
        RegistroDTO ObterPorAno(int Ano);
        void Inserir(RegistroDTO registro);
        void Excluir(int Ano);
        void Atualizar(RegistroDTO registro);
        public int ObterTotal();
    }
}