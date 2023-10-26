using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
public class FacturaRepository : GenericRepository<Factura>, IFacturaRepository
{
    private readonly FarmaCampusContext _context;

    public FacturaRepository(FarmaCampusContext context) : base(context)
    {
        _context = context;
    }
}
}