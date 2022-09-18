
using AutoMapper;

namespace SolarEnergy.API.Config.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var configMap = new MapperConfiguration(config =>
            {
               config.AddProfile(new ProducaoAutoMapper());
                config.AddProfile(new RegistroAutoMapper());
                config.AddProfile(new UnidadeAutoMapper());
                config.AddProfile(new UsuarioAutoMapper());
            });
            return configMap.CreateMapper();
        }
    }
}