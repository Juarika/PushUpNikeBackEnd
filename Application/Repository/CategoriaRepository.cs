using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
{
    private readonly DbContextNike _context;

    public CategoriaRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
