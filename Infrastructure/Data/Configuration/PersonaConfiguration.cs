using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
        .HasMaxLength(20);

        builder.Property(e => e.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.FechaRegistro)
        .IsRequired().HasColumnType("datetime");

        builder.HasOne(p => p.TiposDocumentos)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdTipoDocumento);

        builder.HasOne(p => p.RolesPersonas)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdRolPersona);

        builder.HasOne(p => p.TiposPersonas)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdTipoPersona);
        
        
    }
}
