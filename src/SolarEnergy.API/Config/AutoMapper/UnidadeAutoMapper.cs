
using AutoMapper;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;


namespace SolarEnergy.API.Config.AutoMapper
{
    public class UnidadeAutoMapper : Profile
    {
        public UnidadeAutoMapper()
        {
            CreateMap<UnidadeDTO, Unidade>().ReverseMap();
        }
    }
}