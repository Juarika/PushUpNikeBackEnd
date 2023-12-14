using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class PagoRepository : GenericRepository<Pago>, IPago
{
    private readonly DbContextNike _context;

    public PagoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
