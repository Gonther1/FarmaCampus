using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
public class MovimientoInventarioRepository : GenericRepositoryStr<MovimientoInventario>, IMovimientoInventarioRepository
{
    private readonly FarmaCampusContext _context;

    public MovimientoInventarioRepository(FarmaCampusContext context) : base(context)
    {
        _context = context;
    }
}
}