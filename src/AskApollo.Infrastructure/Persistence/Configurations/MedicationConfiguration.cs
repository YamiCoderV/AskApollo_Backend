using AskApollo.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class MedicationConfiguration
    : IEntityTypeConfiguration<Medication>
{
    public void Configure(EntityTypeBuilder<Medication> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(150);

        builder.HasIndex(x => x.Name);
    }
}
