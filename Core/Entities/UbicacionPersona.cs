using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class UbicacionPersona
{
    public int IdDireccion { get; set; }
    public string TipoDeVia { get; set; }
    public short NumeroPri { get; set; }
    public short NumeroSec { get; set; }
    public short NumeroTer { get; set; }
    public char LetraPri { get; set; }
    public char LetraSec { get; set; }
    public char LetraTer { get; set; }
    public string Bis { get; set; }
    public char CardinalPri { get; set; }
    public char CardinalSec { get; set; }
    public string Complemento { get; set; }
    public string IdPersona { get; set; }
    public Persona Personas { get; set; }
    public int IdCiudad { get; set; }
    public Ciudad Ciudades { get; set; }
}
