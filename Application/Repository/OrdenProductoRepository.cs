using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class OrdenProductoRepository : GenericRepository<OrdenProducto>, IOrdenProducto
{
    private readonly DbContextNike _context;

    public OrdenProductoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
