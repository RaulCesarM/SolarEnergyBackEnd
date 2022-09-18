
using AutoMapper;
using SolarEnergy.Domain.DTO;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.API.Config.AutoMapper
{
    public class RegistroAutoMapper : Profile
    {
        public RegistroAutoMapper()
        {
            CreateMap<RegistroDTO, Registro>().ReverseMap();
        }
    }
}