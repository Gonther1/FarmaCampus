using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Producto : BaseEntityStr
{
    public string NombreProducto { get; set; }
    public int IdMarca { get; set; }
    public Marca Marcas { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
}
