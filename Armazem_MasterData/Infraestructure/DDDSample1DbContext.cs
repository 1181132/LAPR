using Microsoft.EntityFrameworkCore;
using DDDSample1.Domain.Entregas;
using DDDSample1.Infrastructure.Entregas;
using DDDSample1.Domain.Armazens;
using DDDSample1.Infrastructure.Armazens;

namespace DDDSample1.Infrastructure
{
    public class DDDSample1DbContext : DbContext
    {
        public DbSet<Armazem> Armazens { get; set; }

        public DbSet<Entrega> Entregas { get; set; }

        public DDDSample1DbContext(DbContextOptions<DDDSample1DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntregaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ArmazemEntityTypeConfiguration());
        }
    }
}