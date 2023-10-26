using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ContactoPersonaRepository : GenericRepository<ContactoPersona>, IContactoPersonaRepository
{
    private readonly FarmaCampusContext _context;

    public ContactoPersonaRepository(FarmaCampusContext context) : base(context)
    {
        _context = context;
    }
}
