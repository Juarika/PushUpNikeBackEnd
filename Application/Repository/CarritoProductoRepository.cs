using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class CarritoProductoRepository : GenericRepository<CarritoProducto>, ICarritoProducto
{
    private readonly DbContextNike _context;

    public CarritoProductoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
