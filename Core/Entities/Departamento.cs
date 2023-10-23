using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Departamento : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<Ciudad> Ciudades { get; set; }
    public int IdPaisFk { get; set; }
    public Pais Paises { get; set; }
}