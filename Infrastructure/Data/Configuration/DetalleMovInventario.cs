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

        builder.HasKey(c => c.IdInventario);
        builder.HasKey(c => c.IdMovInv); 
/*         builder.Property(e => e.IdInventario)
        .HasMaxLength(10);
        builder.HasKey(c => new {c.IdInventario, c.IdMovInv});

        builder.Property(a => new {a.IdInventario,a.IdMovInv}).HasMaxLength(10);

        builder.Property(e => e.IdMovInv)
        .HasMaxLength(10); */



        
        /* builder.Property(c => new {c.IdInventario, c.IdMovInv}); */
/*         builder.Property(p => p.IdInventario)
        .HasMaxLength(10);
*/


        builder.Property(p => p.IdMovInv)
        .HasMaxLength(10);  

        builder.Property(p => p.IdMovInv)
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
