using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class OrdenRepository : GenericRepository<Orden>, IOrden
{
    private readonly DbContextNike _context;

    public OrdenRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
