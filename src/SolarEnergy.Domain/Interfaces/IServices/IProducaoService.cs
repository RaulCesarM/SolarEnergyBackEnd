using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Domain.Interfaces.IServices
{
    public interface IProducaoService
    {
        IList<ProducaoDTO> ObterTodos(Paginacao paginacao);
        ProducaoDTO ObterPorId(int id);
        void Inserir(ProducaoDTO producao);
        void Excluir(int id);
        void Atualizar(ProducaoDTO producao);
        public int ObterTotal();
    }
}