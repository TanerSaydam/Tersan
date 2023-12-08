using Microsoft.EntityFrameworkCore;

namespace ElasticSearchWebApi.Context;

public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-3BJ5GK9\\SQLEXPRESS;Initial Catalog=ElasticSearchDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<User> Users { get; set; }
}

public class User
{
    public User()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string AboutMe { get; set; }
}
