using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos;

public class ContactoPersonaDto
{
    public int Id { get; set; }
    public int IdTipoContacto { get; set; }
    public string IdPersona { get; set; }
}
