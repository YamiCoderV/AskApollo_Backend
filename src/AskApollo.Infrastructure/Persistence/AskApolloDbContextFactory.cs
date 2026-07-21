using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AskApollo.Infrastructure.Persistence;

public sealed class AskApolloDbContextFactory
    : IDesignTimeDbContextFactory<AskApolloDbContext>
{
    public AskApolloDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AskApolloDbContext>();

        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=AskApollo;Username=amiyyadav");

        return new AskApolloDbContext(optionsBuilder.Options);
    }
}
