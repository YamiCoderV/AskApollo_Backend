using AskApollo.Domain.Entities.Billing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class BillConfiguration
    : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.TotalAmount)
            .HasPrecision(10,2);
    }
}
