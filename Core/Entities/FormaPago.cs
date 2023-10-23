using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class FormaPago : BaseEntityInt
{
    public string Nombre { get; set; }
    public ICollection<MovimientoInventario> MovimientosInventarios { get; set; }
}
