using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
         builder.HasKey(ii => ii.Id);

        builder.Property(ii => ii.Description)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(ii => ii.Quantity)
               .IsRequired();

        builder.Property(ii => ii.UnitPrice)
               .HasPrecision(18,2);

        builder.Property(ii => ii.Total)
               .HasPrecision(18,2);
    }
}