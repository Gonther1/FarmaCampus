using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DetalleMovInventarioConfiguration : IEntityTypeConfiguration<DetalleMovInventario>
{
    public void Configure(EntityTypeBuilder<DetalleMovInventario> builder)
    {
        builder.ToTable("detallemovinventario");

        builder.HasKey(e => e.IdInventario);
        builder.Property(e => e.IdInventario)
        .HasMaxLength(10);

        builder.HasKey(e => e.IdMovInv);
        builder.Property(e => e.IdMovInv)
        .HasMaxLength(10);

        builder.Property(p => p.Cantidad)
        .IsRequired().HasColumnType("int");
        
        builder.Property(p => p.Precio)
        .IsRequired().HasColumnType("double");

        builder.HasOne(p => p.Inventarios)
        .WithMany(p => p.DetallesMovInventarios)
        .HasForeignKey(p => p.IdInventario);

        builder.HasOne(p => p.MovimientosInventarios)
        .WithMany(p => p.DetallesMovInventarios)
        .HasForeignKey(p => p.IdMovInv);
    }
}
