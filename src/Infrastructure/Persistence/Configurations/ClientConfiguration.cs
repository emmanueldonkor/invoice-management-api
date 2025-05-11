using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CompanyName)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(c => c.ContactName)
               .HasMaxLength(100);

        builder.Property(c => c.Email)
               .HasMaxLength(100);

        builder.Property(c => c.Phone)
               .HasMaxLength(20);

        builder.Property(c => c.Address)
               .HasMaxLength(200);
    }
}