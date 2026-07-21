using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Visits;

public sealed class Visit : BaseAuditableEntity
{
    public Guid PatientId { get; private set; }

    public DateTime VisitDateUtc { get; private set; } = DateTime.UtcNow;

    public string ChiefComplaint { get; private set; } = string.Empty;

    public string ClinicalNotes { get; private set; } = string.Empty;

    public string Diagnosis { get; private set; } = string.Empty;

    public bool IsCompleted { get; private set; }

    private Visit()
    {
    }
}
