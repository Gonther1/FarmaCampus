using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class UbicacionPersona : BaseEntityInt
{
    public int IdDireccion { get; set; }
    public string TipoDeVia { get; set; }
    public int NumeroPri { get; set; }
    public int NumeroSec { get; set; }
    public int NumeroTer { get; set; }
    public string LetraPri { get; set; }
    public string LetraSec { get; set; }
    public string LetraTer { get; set; }
    public string Bis { get; set; }
    public string CardinalPri { get; set; }
    public string CardinalSec { get; set; }
    public string Complemento { get; set; }
    public string IdPersona { get; set; }
    public Persona Personas { get; set; }
    public int IdCiudad { get; set; }
    public Ciudad Ciudades { get; set; }
}
