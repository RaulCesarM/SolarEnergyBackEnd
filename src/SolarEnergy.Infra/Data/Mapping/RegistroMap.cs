

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarEnergy.Domain.Models;

namespace SolarEnergy.Infra.Data.Mapping
{
    public class RegistroMap : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("REGISTRO");
            builder.HasKey(r => r.Ano).HasName("ANO");
            builder.Property(r => r.Ano).HasColumnType("uniqueidentifier");


        }

    }
}

