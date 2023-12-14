using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

public partial class DbContextNike : DbContext
{
    public DbContextNike(DbContextOptions options)
        : base(options) { }

    public DbSet<Carrito> Carritos { get; set; }
    public DbSet<CarritoProducto> CarritoProductos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<FormaPago> FormaPagos { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<OrdenProducto> OrdenProductos { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<UserRol> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
