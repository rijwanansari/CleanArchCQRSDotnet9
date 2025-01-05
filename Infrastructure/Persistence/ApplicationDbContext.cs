using System;
using Domain.Aggregates.UserAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

/// <summary>
/// Represents the application's database context.
/// </summary>
/// <remarks>
/// This class is responsible for interacting with the database using Entity Framework Core.
/// It includes a DbSet for UserProfiles and applies configurations from the current assembly.
/// </remarks>
/// <param name="options">The options to be used by the DbContext.</param>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
