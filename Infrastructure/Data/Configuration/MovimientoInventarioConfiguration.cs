using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MovimientoInventarioConfiguration : IEntityTypeConfiguration<MovimientoInventario>
{
    public void Configure(EntityTypeBuilder<MovimientoInventario> builder)
    {
        builder.ToTable("movimientoinventario");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.FechaMovimiento)
        .IsRequired().HasColumnType("datetime");

        builder.Property(p => p.FechaVencimiento)
        .IsRequired().HasColumnType("datetime");

        builder.HasOne(p => p.TiposMovInventarios)
        .WithMany(p => p.MovimientosInventarios)
        .HasForeignKey(p => p.IdTipoMovInv);

        builder.HasOne(p => p.FormasPagos)
        .WithMany(p => p.MovimientosInventarios)
        .HasForeignKey(p => p.IdFormaPago);

        builder.HasOne(p => p.PersonasRespon)
        .WithMany(p => p.MovimientosInventarios)
        .HasForeignKey(p => p.IdResponsable);

        builder.HasOne(p => p.PersonasRecep)
        .WithMany(p => p.MovimientosInventarios)
        .HasForeignKey(p => p.IdReceptor);        
        
        /* builder.HasOne(p => p.Departamentos)
        .WithMany(p => p.Ciudades)
        .HasForeignKey(p => p.IdDepartamentoFk); */
    }
}
