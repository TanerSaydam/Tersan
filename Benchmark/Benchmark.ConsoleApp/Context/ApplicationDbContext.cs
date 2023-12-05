using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Benchmark.ConsoleApp.Context;
public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-3BJ5GK9\\SQLEXPRESS;Initial Catalog=TestBenchMarkDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        List<User> users = new();
        for (int i = 0; i < 10000; i++)
        {
            Faker faker = new();

            User user = new()
            {
                Name = faker.Name.FullName()
            };
        }

        modelBuilder.Entity<User>().HasData(users);
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
