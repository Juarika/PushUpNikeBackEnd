using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class CarritoProductoConfiguration : IEntityTypeConfiguration<CarritoProducto>
{
    public void Configure(EntityTypeBuilder<CarritoProducto> builder)
    {
        builder.ToTable("carrito_producto");

        builder.Property(e => e.Cantidad)
            .HasColumnType("int")
            .HasColumnName("cantidad");
        builder.Property(e => e.IdCarrito)
            .HasColumnName("id_carrito");
        builder.Property(e => e.IdProducto)
            .HasColumnName("id_producto");
    }
}