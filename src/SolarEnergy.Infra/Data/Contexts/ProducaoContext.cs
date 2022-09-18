
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SolarEnergy.Domain.Models;
using SolarEnergy.Infra.Data.Mapping;

namespace SolarEnergy.Infra.Data.Contexts
{
    
    public class ProducaoContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ProducaoContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Producao> Producoes { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseSqlServer(_configuration.GetConnectionString("DeveloperConection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProducaoMap());
            modelBuilder.ApplyConfiguration(new RegistroMap());
            modelBuilder.ApplyConfiguration(new UnidadeMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

        }
    }
}