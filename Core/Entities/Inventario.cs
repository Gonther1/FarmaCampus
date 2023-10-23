using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Inventario : BaseEntityStr
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public short Stock { get; set; }
    public short StockMin { get; set; }
    public short StockMax { get; set; }
    public string CodProducto { get; set; }
    public int IdPresentacion { get; set; }
    public Presentacion Presentaciones { get; set; }
}
