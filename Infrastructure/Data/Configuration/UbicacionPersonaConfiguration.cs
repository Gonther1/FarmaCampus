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
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id);

        builder.Property(p => p.IdDireccion)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.TipoDeVia)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.NumeroPri)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.NumeroSec)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.NumeroTer)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.LetraPri)
        .IsRequired()
        .HasMaxLength(2);

        builder.Property(p => p.LetraSec)
        .IsRequired()
        .HasMaxLength(2);

        builder.Property(p => p.LetraTer)
        .IsRequired()
        .HasMaxLength(2);

        builder.Property(p => p.CardinalPri)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.CardinalSec)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Bis)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(p => p.Complemento)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.IdPersona).HasMaxLength(20);

        builder.HasOne(p => p.Personas)
        .WithMany(p => p.UbicacionesPersonas)
        .HasForeignKey(p => p.IdPersona);

        builder.HasOne(p => p.Ciudades)
        .WithMany(p => p.UbicacionesPersonas)
        .HasForeignKey(p => p.IdCiudad);

    }
}
