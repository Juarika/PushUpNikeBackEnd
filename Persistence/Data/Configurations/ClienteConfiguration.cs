using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");

        builder.Property(e => e.IdCliente)
            .HasMaxLength(50)
            .HasColumnName("id_cliente");
        builder.Property(e => e.Nombre)
            .HasMaxLength(50)
            .HasColumnName("nombre");
        builder.Property(e => e.Apellido)
            .HasMaxLength(50)
            .HasColumnName("apellido");
        builder.Property(e => e.FechaRegistro)
            .HasColumnName("fecha_registro");
        builder.Property(e => e.IdUser)
            .HasColumnName("id_user");
    }
}