using AskApollo.Domain.Entities.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Mrn)
            .HasMaxLength(20)
            .IsRequired();

        builder.HasIndex(x => x.Mrn)
            .IsUnique();

        builder.Property(x => x.FirstName)
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .HasMaxLength(100);

        builder.Property(x => x.PhoneNumber)
            .HasMaxLength(20);
    }
}
