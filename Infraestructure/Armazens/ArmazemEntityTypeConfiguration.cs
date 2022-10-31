using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DDDSample1.Domain.Armazens;

namespace DDDSample1.Infrastructure.Armazens
{
    internal class ArmazemEntityTypeConfiguration : IEntityTypeConfiguration<Armazem>
    {
        public void Configure(EntityTypeBuilder<Armazem> builder)
        {
            // cf. https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
            
            //builder.ToTable("Armazens", SchemaNames.DDDSample1);
            builder.HasKey(b => b.Id);
            builder.OwnsOne(b => b.Designacao);
            builder.OwnsOne(b => b.Endereco);
            builder.OwnsOne(b => b.Coordenadas);
            //builder.Property<bool>("_active").HasColumnName("Active");
        }
    }
}