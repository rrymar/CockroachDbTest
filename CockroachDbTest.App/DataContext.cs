using Microsoft.EntityFrameworkCore;

namespace CockroachDbTest.App;

public class DataContext : DbContext
{
    public DbSet<Entity1> Entities1 { get; set; }
    
    public DataContext()
    {
        Database.EnsureCreated();
    }

    public void Migrate()
    {
        Database.Migrate();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=poc-test-8457.8nj.cockroachlabs.cloud;Port=26257;Database=defaultdb;Username=ruslan;Password=I5FwVjKWBfxYv1Ms4Uhpdg");
    }
}