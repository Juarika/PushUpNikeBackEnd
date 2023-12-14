using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("orden");

        builder.Property(e => e.Direccion)
            .HasMaxLength(50)
            .HasColumnName("direccion");
        builder.Property(e => e.Total)
            .HasPrecision(15,2)
            .HasColumnName("total");
        builder.Property(e => e.IdUser)
            .HasColumnName("id_user");
        builder.Property(e => e.IdEstado)
            .HasColumnName("id_estado");
    }
}