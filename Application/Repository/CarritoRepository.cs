using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class CarritoRepository : GenericRepository<Carrito>, ICarrito
{
    private readonly DbContextNike _context;

    public CarritoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
