using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
{
    private readonly FarmaCampusContext _context;

    public TipoPersonaRepository(FarmaCampusContext context) : base(context)
    {
        _context = context;
    }
}
