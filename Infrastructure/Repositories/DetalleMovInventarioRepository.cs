using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
public class DetalleMovInventarioRepository : GenericRepository<DetalleMovInventario>, IDetalleMovInventarioRepository
{
    private readonly FarmaCampusContext _context;

    public DetalleMovInventarioRepository(FarmaCampusContext context) : base(context)
    {
        _context = context;
    }
}
}