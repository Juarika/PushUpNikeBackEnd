using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class EstadoRepository : GenericRepository<Estado>, IEstado
{
    private readonly DbContextNike _context;

    public EstadoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
