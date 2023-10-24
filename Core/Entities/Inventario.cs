using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Inventario : BaseEntityStr
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public int IdPresentacion { get; set; }
    public Presentacion Presentaciones { get; set; }
    public string CodProducto { get; set; }
    public Producto Productos { get; set; }
    public ICollection<DetalleMovInventario> DetallesMovInventarios { get; set; }
}
