using AskApollo.Domain.Entities.Billing;
using AskApollo.Domain.Entities.Catalog;
using AskApollo.Domain.Entities.Patients;
using AskApollo.Domain.Entities.Prescriptions;
using AskApollo.Domain.Entities.Users;
using AskApollo.Domain.Entities.Visits;
using Microsoft.EntityFrameworkCore;

namespace AskApollo.Infrastructure.Persistence;

public sealed class AskApolloDbContext : DbContext
{
    public AskApolloDbContext(DbContextOptions<AskApolloDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patients => Set<Patient>();

    public DbSet<Visit> Visits => Set<Visit>();

    public DbSet<Prescription> Prescriptions => Set<Prescription>();

    public DbSet<Medication> Medications => Set<Medication>();

    public DbSet<Bill> Bills => Set<Bill>();

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AskApolloDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
