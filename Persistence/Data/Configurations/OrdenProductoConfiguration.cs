using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class OrdenProductoConfiguration : IEntityTypeConfiguration<OrdenProducto>
{
    public void Configure(EntityTypeBuilder<OrdenProducto> builder)
    {
        builder.ToTable("orden_producto");

        builder.Property(e => e.Precio)
            .HasMaxLength(50)
            .HasColumnName("precio");
        builder.Property(e => e.Cantidad)
            .HasColumnType("int")
            .HasColumnName("cantidad");
        builder.Property(e => e.IdOrden)
            .HasColumnName("id_orden");
        builder.Property(e => e.IdProducto)
            .HasColumnName("id_producto");
    }
}