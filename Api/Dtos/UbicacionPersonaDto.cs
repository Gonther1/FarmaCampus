using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dtos;

public class UbicacionPersonaDto
{
    public int Id { get; set; }
    public int IdDireccion { get; set; }
    public int NumeroPri { get; set; }
    public int NumeroSec { get; set; }
    public string LetraPri { get; set; }
    public string LetraSec { get; set; }
    public string CardinalPri { get; set; }
    public string CardinalSec { get; set; }
    public string Complemento { get; set; }
    public string IdPersona { get; set; }
    public int IdCiudad { get; set; }
}
