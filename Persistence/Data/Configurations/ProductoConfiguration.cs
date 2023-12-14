using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.Property(e => e.Titulo)
            .HasMaxLength(50)
            .HasColumnName("titulo");
        builder.Property(e => e.Imagen)
            .HasMaxLength(50)
            .HasColumnName("imagen");
        builder.Property(e => e.Precio)
            .HasPrecision(15, 2)
            .HasColumnName("precio");
        builder.Property(e => e.IdCategoria)
            .HasColumnName("id_categoria");
    }
}