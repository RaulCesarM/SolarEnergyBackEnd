
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Domain.Interfaces.IServices
{
    public interface IUserService
    {
        IList<UsuarioDTO> ObterTodos(Paginacao paginacao);
        UsuarioDTO ObterPorId(int id);
        void Inserir(UsuarioDTO usuario);
        void Excluir(int id);
        void Atualizar(UsuarioDTO usuario);
        public int ObterTotal();
    }
}