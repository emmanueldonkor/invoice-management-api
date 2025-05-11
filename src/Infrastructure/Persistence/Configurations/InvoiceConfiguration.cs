using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
         builder.HasKey(i => i.Id);

        builder.Property(i => i.InvoiceNumber)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(i => i.Total)
               .HasPrecision(18,2);

        builder.Property(i => i.Status)
               .IsRequired();

        builder.HasOne(i => i.Client)
               .WithMany(c => c.Invoices)
               .HasForeignKey(i => i.ClientId);

        builder.HasMany(i => i.Items)
               .WithOne()
               .HasForeignKey(ii => ii.InvoiceId);
    
    }
}