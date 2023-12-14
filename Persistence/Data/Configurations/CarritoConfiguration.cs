using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class CarritoConfiguration : IEntityTypeConfiguration<Carrito>
{
    public void Configure(EntityTypeBuilder<Carrito> builder)
    {
        builder.ToTable("carrito");

        builder.Property(e => e.Nombre)
            .HasMaxLength(50)
            .HasColumnName("nombre");
        builder.Property(e => e.IdUser)
            .HasColumnName("id_user");
    }
}