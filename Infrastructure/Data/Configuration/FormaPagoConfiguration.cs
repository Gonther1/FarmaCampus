using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class FormaPagoConfiguration : IEntityTypeConfiguration<FormaPago>
{
    public void Configure(EntityTypeBuilder<FormaPago> builder)
    {
        builder.ToTable("formapago");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}
