using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoMovInventarioConfiguration : IEntityTypeConfiguration<TipoMovInventario>
{
    public void Configure(EntityTypeBuilder<TipoMovInventario> builder)
    {
        builder.ToTable("tipomovinventario");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
        
    }
}
