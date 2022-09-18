
using AutoMapper;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.API.Config.AutoMapper
{
    public class ProducaoAutoMapper : Profile
    {
        public ProducaoAutoMapper()
        {
            CreateMap<ProducaoDTO, Producao>().ReverseMap();
        }
        
    }
}