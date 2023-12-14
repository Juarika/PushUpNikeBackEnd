using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;

public class ProductoRepository : GenericRepository<Producto>, IProducto
{
    private readonly DbContextNike _context;

    public ProductoRepository(DbContextNike context)
        : base(context)
    {
        _context = context;
    }
}
