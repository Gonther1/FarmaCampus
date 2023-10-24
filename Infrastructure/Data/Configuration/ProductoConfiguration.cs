using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
        .HasMaxLength(10);

        builder.Property(p => p.NombreProducto)
        .IsRequired()
        .HasMaxLength(100);
        
        builder.HasOne(p => p.Marcas)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.IdMarca);
    }
}
