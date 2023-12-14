using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;
public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPago
{
    private readonly DbContextNike _context;

    public FormaPagoRepository(DbContextNike context) : base(context)
    {
        _context = context;
    }
}
