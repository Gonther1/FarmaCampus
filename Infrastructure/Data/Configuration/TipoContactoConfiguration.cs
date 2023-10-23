using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoContactoConfiguration
 : IEntityTypeConfiguration<TipoContacto>
{
    public void Configure(EntityTypeBuilder<TipoContacto> builder)
    {
        builder.ToTable("tipocontacto");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
        
    }
}
