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
    /* public CiudadRepository Ciudades
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
    } */

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
