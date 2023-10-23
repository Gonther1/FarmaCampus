using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Persona : BaseEntityStr
{
    public string Nombre { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdDocumento { get; set; }
    public int IdTipoDocumento { get; set; }
    public TipoDocumento TiposDocumentos { get; set; }
    public int IdRolPersona { get; set; }
    public RolPersona RolesPersonas { get; set; }
    public int IdTipoPersona { get; set; }
    public TipoPersona TiposPersonas { get; set; }
    public ICollection<MovimientoInventario> MovimientosInventarios { get; set; }
    public ICollection<UbicacionPersona> UbicacionesPersonas { get; set; }
    public ICollection<ContactoPersona> ContactosPersonas { get; set; }
}
