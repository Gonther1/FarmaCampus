using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class DetalleMovInventario 
{
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public string IdInventario { get; set; }
    public Inventario Inventarios { get; set; }
    public string IdMovInv { get; set; }
    public MovimientoInventario MovimientosInventarios { get; set; }
    
}
