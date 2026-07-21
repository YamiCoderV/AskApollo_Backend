using AskApollo.Domain.Entities.Common;

namespace AskApollo.Domain.Entities.Patients;

public sealed class Patient : BaseAuditableEntity
{
    public string Mrn { get; private set; } = string.Empty;

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public DateOnly DateOfBirth { get; private set; }

    public string Gender { get; private set; } = string.Empty;

    public string PhoneNumber { get; private set; } = string.Empty;

    public string? Email { get; private set; }

    public string? Address { get; private set; }

    public string? EmergencyContactName { get; private set; }

    public string? EmergencyContactPhone { get; private set; }

    public string? BloodGroup { get; private set; }

    public string? Allergies { get; private set; }

    public string? MedicalAlerts { get; private set; }

    public int Age =>
        DateTime.Today.Year -
        DateOfBirth.Year -
        (DateOnly.FromDateTime(DateTime.Today) < DateOfBirth.AddYears(DateTime.Today.Year - DateOfBirth.Year) ? 1 : 0);

    private Patient()
    {
    }
}
