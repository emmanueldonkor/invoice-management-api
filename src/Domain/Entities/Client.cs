namespace Domain.Entities;

public class Client
{
    public Guid Id { get; set; }
    public required string CompanyName { get; set; }
    public string? ContactName { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public string? Address { get; set; }

    public ICollection<Invoice> Invoices { get; set; } = [];
}