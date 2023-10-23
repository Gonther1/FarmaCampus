using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UbicacionPersonaConfiguration : IEntityTypeConfiguration<UbicacionPersona>
{
    public void Configure(EntityTypeBuilder<UbicacionPersona> builder)
    {
        builder.ToTable("ubicacionpersona");
        
        builder.Property(p => p.IdDireccion)
        .IsRequired().HasColumnType("int");

        builder.Property(p => p.NumeroPri)
        .IsRequired()
        .HasColumnType("short");

        builder.Property(p => p.NumeroSec)
        .IsRequired()
        .HasColumnType("short");

        builder.Property(p => p.NumeroTer)
        .IsRequired()
        .HasColumnType("short");

        builder.Property(p => p.LetraPri)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(2);

        builder.Property(p => p.LetraSec)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(2);

        builder.Property(p => p.LetraTer)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(2);

        builder.Property(p => p.CardinalPri)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(10);

        builder.Property(p => p.CardinalSec)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(10);

        builder.Property(p => p.Bis)
        .IsRequired()
        .HasColumnType("char")
        .HasMaxLength(10);

        builder.Property(p => p.Complemento)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Personas)
        .WithMany(p => p.UbicacionesPersonas)
        .HasForeignKey(p => p.IdPersona);

        builder.HasOne(p => p.Ciudades)
        .WithMany(p => p.UbicacionesPersonas)
        .HasForeignKey(p => p.IdCiudad);

    }
}
