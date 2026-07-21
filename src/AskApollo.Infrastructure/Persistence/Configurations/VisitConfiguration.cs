using AskApollo.Domain.Entities.Visits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class VisitConfiguration : IEntityTypeConfiguration<Visit>
{
    public void Configure(EntityTypeBuilder<Visit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ChiefComplaint)
            .HasMaxLength(500);

        builder.Property(x => x.Diagnosis)
            .HasMaxLength(500);
    }
}
