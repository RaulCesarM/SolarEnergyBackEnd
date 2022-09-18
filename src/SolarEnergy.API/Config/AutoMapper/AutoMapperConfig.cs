
using AutoMapper;

namespace SolarEnergy.API.Config.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var configMap = new MapperConfiguration(config =>
            {
              //  config.AddProfile(new ClasseaserusadaAutoMapper());
            });
            return configMap.CreateMapper();
        }
    }
}