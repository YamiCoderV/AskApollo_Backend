using AskApollo.Domain.Entities.Patients;

namespace AskApollo.Application.Features.Patients.Repositories;

public interface IPatientRepository
{
    Task<Patient?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<Patient?> GetByMrnAsync(string mrn, CancellationToken cancellationToken);

    Task<Patient?> GetByPhoneAsync(string phone, CancellationToken cancellationToken);

    Task AddAsync(Patient patient, CancellationToken cancellationToken);

    Task<bool> ExistsByMrnAsync(string mrn, CancellationToken cancellationToken);

    Task SaveChangesAsync(CancellationToken cancellationToken);
}
