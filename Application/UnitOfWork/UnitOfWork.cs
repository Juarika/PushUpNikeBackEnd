using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbContextNike _context;
    private ICarrito _carritos;
    private ICarritoProducto _carritoProductos;
    private ICategoria _categorias;
    private ICliente _clientes;
    private IEstado _estados;
    private IFormaPago _formaPagos;
    private IOrden _ordenes;
    private IOrdenProducto _ordenProductos;
    private IPago _pagos;
    private IProducto _productos;
    private IRol _roles;
    private IUser _users;
    private IUserRol _userole;
    public UnitOfWork(DbContextNike context)
    {
        _context = context;
    }
    public ICarrito Carritos
    {
        get
        {
            if (_carritos == null)
            {
                _carritos = new CarritoRepository(_context);
            }
            return _carritos;
        }
    }
    public ICarritoProducto CarritoProductos
    {
        get
        {
            if (_carritoProductos == null)
            {
                _carritoProductos = new CarritoProductoRepository(_context);
            }
            return _carritoProductos;
        }
    }
    public ICategoria Categorias
    {
        get
        {
            if (_categorias == null)
            {
                _categorias = new CategoriaRepository(_context);
            }
            return _categorias;
        }
    }
    public ICliente Clientes
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }
    public IEstado Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IFormaPago FormaPagos
    {
        get
        {
            if (_formaPagos == null)
            {
                _formaPagos = new FormaPagoRepository(_context);
            }
            return _formaPagos;
        }
    }
    public IOrden Ordenes
    {
        get
        {
            if (_ordenes == null)
            {
                _ordenes = new OrdenRepository(_context);
            }
            return _ordenes;
        }
    }
    public IOrdenProducto OrdenProductos
    {
        get
        {
            if (_ordenProductos == null)
            {
                _ordenProductos = new OrdenProductoRepository(_context);
            }
            return _ordenProductos;
        }
    }
    public IPago Pagos
    {
        get
        {
            if (_pagos == null)
            {
                _pagos = new PagoRepository(_context);
            }
            return _pagos;
        }
    }
    public IProducto Productos
    {
        get
        {
            if (_productos == null)
            {
                _productos = new ProductoRepository(_context);
            }
            return _productos;
        }
    }
    public IRol Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }
    public IUserRol UserRoles
    {
        get
        {
            if (_userole == null)
            {
                _userole = new UserRolRepository(_context);
            }
            return _userole;
        }
    }
    public IUser Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}