using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("inventario");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Precio)
        .IsRequired().HasColumnType("double");

        builder.Property(p => p.Stock)
        .IsRequired().HasColumnType("short");
        
        builder.Property(p => p.StockMin)
        .IsRequired().HasColumnType("short");

        builder.Property(p => p.StockMax)
        .IsRequired().HasColumnType("short");

        builder.HasOne(p => p.Productos)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.CodProducto);

        builder.HasOne(p => p.Presentaciones)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdPresentacion);
        
        
        /* builder.HasOne(p => p.Departamentos)
        .WithMany(p => p.Ciudades)
        .HasForeignKey(p => p.IdDepartamentoFk); */
    }
}
