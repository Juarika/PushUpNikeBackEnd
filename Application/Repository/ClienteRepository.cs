using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class ClienteRepository : GenericRepository<Cliente>, ICliente
{
    private readonly DbContextNike _context;

    public ClienteRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
