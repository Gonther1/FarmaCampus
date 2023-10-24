using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class FarmaCampusContext : DbContext
{
    public FarmaCampusContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<ContactoPersona> ContactosPersonas { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<DetalleMovInventario> DetallesMovInventarios { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<FormaPago> FormasPagos { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<MovimientoInventario> MovimientosInventarios { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Presentacion> Presentaciones { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<RolPersona> RolesPersonas { get; set; }
    public DbSet<TipoContacto> TiposContactos { get; set; }
    public DbSet<TipoDocumento> TiposDocumentos { get; set; }
    public DbSet<TipoMovInventario> TiposMovInventarios { get; set; }
    public DbSet<UbicacionPersona> UbicacionesPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)		
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
