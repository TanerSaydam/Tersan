using Microsoft.EntityFrameworkCore;
using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Context;

public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }

    public DbSet<User> Users { get; set; }
}
