using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Factura : BaseEntityInt
{
    public int FacturaInicial { get; set; }
    public int FacturaFinal { get; set; }
    public int FacturaActual { get; set; }
    public string NroResolucion { get; set; }
    public string IdPersona { get; set; }
    public Persona Personas { get; set; }
    public string IdDetalleMovimiento { get; set; }
    public DetalleMovInventario DetallesMovInventarios { get; set; }

}