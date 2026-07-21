using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Prescriptions;

public sealed class Prescription : BaseAuditableEntity
{
    public Guid VisitId { get; private set; }

    public string MedicationName { get; private set; } = string.Empty;

    public string Strength { get; private set; } = string.Empty;

    public string Dosage { get; private set; } = string.Empty;

    public string Frequency { get; private set; } = string.Empty;

    public string Duration { get; private set; } = string.Empty;

    public string Instructions { get; private set; } = string.Empty;

    private Prescription()
    {
    }
}
