using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.ToTable("factura");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.FacturaInicial)
        .IsRequired().HasColumnType("int");

        builder.Property(p => p.FacturaFinal)
        .IsRequired().HasColumnType("int");
        
        builder.Property(p => p.FacturaActual)
        .IsRequired().HasColumnType("int");

        builder.Property(p => p.NroResolucion)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.IdDetalleMovimiento)
        .HasMaxLength(20);

        builder.Property(p => p.IdPersona)
        .HasMaxLength(20);

        builder.HasOne(p => p.Personas)
        .WithMany(p => p.Facturas)
        .HasForeignKey(p => p.IdPersona);

        builder.HasOne(p => p.DetallesMovInventarios)
        .WithMany(p => p.Facturas)
        .HasForeignKey(p => p.IdDetalleMovimiento);
        
    }
}