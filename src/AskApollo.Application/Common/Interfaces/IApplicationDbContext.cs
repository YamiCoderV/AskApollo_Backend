using AskApollo.Domain.Entities.Patients;

namespace AskApollo.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    Task AddPatientAsync(
        Patient patient,
        CancellationToken cancellationToken);

    Task<int> SaveChangesAsync(
        CancellationToken cancellationToken);
}