using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Repositories;
using System.Reflection;

namespace NTierArchitecture.DataAccess.Context;
public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
