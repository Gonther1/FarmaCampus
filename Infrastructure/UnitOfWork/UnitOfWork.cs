using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly FarmaCampusContext _context;
    private CiudadRepository _ciudades;
    private ContactoPersonaRepository _contactospersonas;
    private DepartamentoRepository _departamentos;
    private DetalleMovInventarioRepository _detallesmovinventario;
    private FacturaRepository _facturas;
    private FormaPagoRepository _formaspagos;
    private InventarioRepository _inventarios;
    private MarcaRepository _marcas;
    private MovimientoInventarioRepository _movimientosinventarios;
    private PaisRepository _paises;
    private PersonaRepository _personas;
    private PresentacionRepository _presentaciones;
    private ProductoRepository _productos;
    private RoPersonaRepository _rolespersonas;
    private TipoContactoRepository _tiposcontactos;
    private TipoDocumentoRepository _tiposdocumentos;
    private UbicacionPersonaRepository _ubicacionespersonas;
    public CiudadRepository Ciudades
    {
        get 
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context);
            }
            return _ciudades;
        }
    }
    public ContactoPersonaRepository ContactosPersonas
    {
        get 
        {
            if (_contactospersonas == null)
            {
                _contactospersonas = new ContactoPersonaRepository(_context);
            }
            return _contactospersonas;
        }
    }
    
    public DepartamentoRepository Departamentos
    {
        get 
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public DetalleMovInventarioRepository DetallesMovInventarios
    {
        get 
        {
            if (_detallesmovinventario == null)
            {
                _detallesmovinventario = new DetalleMovInventarioRepository(_context);
            }
            return _detallesmovinventario;
        }
    }
    public FacturaRepository Facturas
    {
        get 
        {
            if (_facturas == null)
            {
                _facturas = new FacturaRepository(_context);
            }
            return _facturas;
        }
    }
    public FormaPagoRepository FormasPagos
    {
        get 
        {
            if (_formaspagos == null)
            {
                _formaspagos = new FormaPagoRepository(_context);
            }
            return _formaspagos;
        }
    }
    public InventarioRepository Inventarios
    {
        get 
        {
            if (_inventarios == null)
            {
                _inventarios = new InventarioRepository(_context);
            }
            return _inventarios;
        }
    }
    public MarcaRepository Marcas
    {
        get 
        {
            if (_marcas == null)
            {
                _marcas = new MarcaRepository(_context);
            }
            return _marcas;
        }
    }
    public MovimientoInventarioRepository MovimientosInventarios
    {
        get 
        {
            if (_movimientosinventarios == null)
            {
                _movimientosinventarios = new MovimientoInventarioRepository(_context);
            }
            return _movimientosinventarios;
        }
    }
    public PaisRepository Paises
    {
        get 
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }
    public PersonaRepository Personas
    {
        get 
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(_context);
            }
            return _personas;
        }
    }
    public PresentacionRepository Presentaciones
    {
        get 
        {
            if (_presentaciones == null)
            {
                _presentaciones = new PresentacionRepository(_context);
            }
            return _presentaciones;
        }
    }
    public ProductoRepository Productos
    {
        get 
        {
            if (_productos == null)
            {
                _productos = new ProductoRepository(_context);
            }
            return _productos;
        }
    }
    public RoPersonaRepository RolesPersonas
    {
        get 
        {
            if (_rolespersonas == null)
            {
                _rolespersonas = new RoPersonaRepository(_context);
            }
            return _rolespersonas;
        }
    }
    public TipoContactoRepository TiposContactos
    {
        get 
        {
            if (_tiposcontactos == null)
            {
                _tiposcontactos = new TipoContactoRepository(_context);
            }
            return _tiposcontactos;
        }
    }
    public TipoDocumentoRepository TiposDocumentos
    {
        get 
        {
            if (_tiposdocumentos == null)
            {
                _tiposdocumentos = new TipoDocumentoRepository(_context);
            }
            return _tiposdocumentos;
        }
    }
    public UbicacionPersonaRepository UbicacionesPersonas
    {
        get 
        {
            if (_ubicacionespersonas == null)
            {
                _ubicacionespersonas = new UbicacionPersonaRepository(_context);
            }
            return _ubicacionespersonas;
        }
    } 
    public UnitOfWork(FarmaCampusContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}
