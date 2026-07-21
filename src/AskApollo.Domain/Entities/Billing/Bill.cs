using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Billing;

public sealed class Bill : BaseAuditableEntity
{
    public Guid VisitId { get; private set; }

    public decimal TotalAmount { get; private set; }

    public bool IsPaid { get; private set; }

    public DateTime? PaidOnUtc { get; private set; }

    private Bill()
    {
    }
}
