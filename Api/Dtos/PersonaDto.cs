using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos;

public class PersonaDto
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int IdTipoDocumento { get; set; }
    public int IdRolPersona { get; set; }
    public int IdTipoPersona { get; set; }
}
