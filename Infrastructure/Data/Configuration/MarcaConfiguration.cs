using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("marca");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        
        /* builder.HasOne(p => p.Departamentos)
        .WithMany(p => p.Ciudades)
        .HasForeignKey(p => p.IdDepartamentoFk); */
    }
}
