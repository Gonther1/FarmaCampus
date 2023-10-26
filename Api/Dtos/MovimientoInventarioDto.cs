using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos;

public class MovimientoInventarioDto
{
    public string Id { get; set; } 
    public DateTime FechaMovimiento { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public int IdTipoMovInv { get; set; }
    public int IdFormaPago { get; set; }
    public string IdResponsable { get; set; }
    public string IdReceptor { get; set; }
}
