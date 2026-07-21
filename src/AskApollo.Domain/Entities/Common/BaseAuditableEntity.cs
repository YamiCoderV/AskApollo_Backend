namespace AskApollo.Domain.Entities.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime CreatedOnUtc { get; protected set; } = DateTime.UtcNow;

    public DateTime? ModifiedOnUtc { get; protected set; }

    public bool IsDeleted { get; protected set; }

    public DateTime? DeletedOnUtc { get; protected set; }

    public void MarkModified()
    {
        ModifiedOnUtc = DateTime.UtcNow;
    }

    public void SoftDelete()
    {
        IsDeleted = true;
        DeletedOnUtc = DateTime.UtcNow;
    }
}