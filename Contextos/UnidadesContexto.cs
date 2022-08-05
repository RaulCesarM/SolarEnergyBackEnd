using Microsoft.EntityFrameworkCore;
using SolarEnergyBackEnd.Models;

namespace SolarEnergyBackEnd.Contextos {
    public class UnidadesContexto : DbContext {        
       
        public UnidadesContexto( DbContextOptions<UnidadesContexto> options) : base(options) {

           
        }
       
        public DbSet<Producao> Producaos { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Unidade>()
               .HasKey(u => u.Id);
            modelBuilder.Entity<Producao>()
               .HasKey(P => P.IdProducao);
            modelBuilder.Entity<Usuario>()
               .HasKey(us => us.IdUsuario);
            modelBuilder.Entity<Registro>()
               .HasKey(Re => Re.IdRegistro);
            ;

        }
    }
}

