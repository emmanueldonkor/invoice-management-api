using Domain.Enums;

namespace Domain.Entities;

public class Invoice
{
    public Guid Id { get; set; }
    public required string InvoiceNumber { get; set; }
    public Guid ClientId { get; set; }
    public required string OwnerId { get; set; }
    public InvoiceStatus Status { get; set; } = InvoiceStatus.UNPAID;

    public required DateTime IssueDate { get; set; }
    public required DateTime DueDate { get; set; }

    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }

    public Client? Client { get; set; }
    public ICollection<InvoiceItem> Items { get; set; } = [];
}