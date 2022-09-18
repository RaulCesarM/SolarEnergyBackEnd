
using AutoMapper;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.API.Config.AutoMapper
{
    public class UsuarioAutoMapper  : Profile
    {
        public UsuarioAutoMapper()
        {
            CreateMap<UsuarioDTO, Usuario>().ReverseMap();
        }
    }
}