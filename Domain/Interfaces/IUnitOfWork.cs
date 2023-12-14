namespace Domain.Interfaces;

public interface IUnitOfWork
{
    ICarrito Carritos { get; }
    ICarritoProducto CarritoProductos { get; }
    ICategoria Categorias { get; }
    ICliente Clientes { get; }
    IEstado Estados { get; }
    IFormaPago FormaPagos { get; }
    IOrden Ordenes { get; }
    IOrdenProducto OrdenProductos { get; }
    IPago Pagos { get; }
    IProducto Productos { get; }
    IRol Roles { get; }
    IUser Users { get; }
    IUserRol UserRoles { get; }
    Task<int> SaveAsync();
}