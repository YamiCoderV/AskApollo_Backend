using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Catalog;

public sealed class Medication : BaseAuditableEntity
{
    public string Name { get; private set; } = string.Empty;

    public string GenericName { get; private set; } = string.Empty;

    public string Strength { get; private set; } = string.Empty;

    public string Form { get; private set; } = string.Empty;

    public bool IsActive { get; private set; } = true;

    private Medication()
    {
    }
}
