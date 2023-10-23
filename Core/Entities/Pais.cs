using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Pais : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<Pais> Paises { get; set; }
}
