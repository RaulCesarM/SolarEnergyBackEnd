

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Infra.Data.Mapping
{
    public class ProducaoMap : IEntityTypeConfiguration<Producao>
    {
        public void Configure(EntityTypeBuilder<Producao> builder)
        {
           
        }
    }
}