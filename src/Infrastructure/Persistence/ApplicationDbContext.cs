using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    { }

    public DbSet<Client> Clients => Set<Client>();

    public DbSet<Invoice> Invoices => Set<Invoice>();

    public DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();
    
}