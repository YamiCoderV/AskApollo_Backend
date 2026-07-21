namespace AskApollo.Application.Features.Patients.RegisterPatient;

public sealed class RegisterPatientResponse
{
    public Guid PatientId { get; set; }

    public string Mrn { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}