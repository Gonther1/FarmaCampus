using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class RolPersona : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<Persona> Personas { get; set; }
}