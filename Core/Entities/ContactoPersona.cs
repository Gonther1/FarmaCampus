using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class ContactoPersona : BaseEntityInt
{
    public int IdTipoContacto { get; set; }
    public TipoContacto TiposContactos { get; set; }
    public string IdPersona { get; set; }
    public Persona Personas { get; set; }
}