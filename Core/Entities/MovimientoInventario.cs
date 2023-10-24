using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class MovimientoInventario : BaseEntityStr
{
    public DateTime FechaMovimiento { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int IdTipoMovInv { get; set; }
    public TipoMovInventario TiposMovInventarios { get; set; }
    public int IdFormaPago { get; set; }
    public FormaPago FormasPagos { get; set; }
    public string IdResponsable { get; set; }
    public string IdReceptor { get; set; }
    public Persona Personas { get; set; }
    public ICollection<DetalleMovInventario> DetallesMovInventarios{ get; set; }
}
