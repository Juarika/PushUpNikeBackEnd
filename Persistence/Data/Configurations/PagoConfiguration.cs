using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class PagoConfiguration : IEntityTypeConfiguration<Pago>
{
    public void Configure(EntityTypeBuilder<Pago> builder)
    {
        builder.ToTable("pago");

        builder.Property(e => e.IdOrden)
            .HasColumnName("id_orden");
        builder.Property(e => e.IdTransacion)
            .HasMaxLength(50)
            .HasColumnName("id_transacion");
        builder.Property(e => e.FechaPago)
            .HasColumnName("fecha_pago");
        builder.Property(e => e.IdFormaPago)
            .HasColumnName("id_forma_pago");
    }
}