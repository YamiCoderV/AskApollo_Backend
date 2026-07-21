using AskApollo.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AskApollo.Infrastructure.Persistence.Configurations;

public sealed class UserConfiguration
    : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Email)
            .HasMaxLength(255);

        builder.HasIndex(x => x.Email)
            .IsUnique();
    }
}
