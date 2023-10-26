using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces;

public interface IUnitOfWork
{
    ICiudadRepository Ciudades { get; }
    IContactoPersonaRepository ContactosPersonas { get; }
    IDepartamentoRepository Departamentos { get; }
    IDetalleMovInventarioRepository DetalleMovInventarios { get; }
    IFacturaRepository Facturas { get; }
    IFormaPagoRepository FormasPagos { get; }
    IInventarioRepository Inventarios { get; }
    IMarcaRepository Marcas { get; }
    IMovimientoInventarioRepository MovimientosInventarios { get; }
    IPaisRepository Paises { get; }
    IPersonaRepository Personas { get; }
    IPresentacionRepository Presentaciones { get; }
    IProductoRepository Productos { get; }
    IRoPersonaRepository Roles { get; }
    ITipoContactoRepository TiposContactos { get; }
    ITipoDocumentoRepository TiposDocumentos { get; }
    ITipoMovInventarioRepository TiposMovInventarios { get; }
    ITipoPersonaRepository TiposPersonas { get; }
    IUbicacionPersonaRepository UbicacionesPersonas { get; }
    Task<int> SaveAsync();
}
