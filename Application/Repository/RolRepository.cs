using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;

public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly DbContextNike _context;

    public RolRepository(DbContextNike context) : base(context)
    {
       _context = context;
    }
}