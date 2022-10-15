using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Seed;
using Microsoft.EntityFrameworkCore;

namespace DevInCar.GraphQL.Context
{
    public class DevContext : DbContext
    {
        public DevContext() { }

        public DevContext(DbContextOptions<DevContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; } = null!;

        public DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasData(VeiculoSeed.VeiculoSeeder);
            modelBuilder.Entity<Usuario>().HasData(UsuarioSeed.UsuarioSeeder);
        }
    }
}
