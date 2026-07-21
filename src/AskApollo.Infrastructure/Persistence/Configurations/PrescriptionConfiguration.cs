using AskApollo.Domain.Entities.Prescriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class PrescriptionConfiguration
    : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.MedicationName)
            .HasMaxLength(150);

        builder.Property(x => x.Dosage)
            .HasMaxLength(100);
    }
}
