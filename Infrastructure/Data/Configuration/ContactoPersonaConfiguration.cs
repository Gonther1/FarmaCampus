using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
{
    public void Configure(EntityTypeBuilder<ContactoPersona> builder)
    {
        builder.ToTable("contactopersona");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.IdPersona).HasMaxLength(20);
        
        builder.HasOne(p => p.Personas)
        .WithMany(p => p.ContactosPersonas)
        .HasForeignKey(p => p.IdPersona);
        
        builder.HasOne(p => p.TiposContactos)
        .WithMany(p => p.ContactosPersonas)
        .HasForeignKey(p => p.IdTipoContacto);
    }
}
