using Microsoft.EntityFrameworkCore;

namespace CockroachDbTest.App;

public class DataContext : DbContext
{
    public DbSet<Entity1> Entities1 { get; set; }
    public DbSet<Entity2> Entities2 { get; set; }
    public DbSet<Entity3> Entities3 { get; set; }
    public DbSet<Entity4> Entities4 { get; set; }
    public DbSet<Entity5> Entities5 { get; set; }
    public DbSet<Entity6> Entities6 { get; set; }
    public DbSet<Entity7> Entities7 { get; set; }
    public DbSet<Entity8> Entities8 { get; set; }
    public DbSet<Entity9> Entities9 { get; set; }
    public DbSet<Entity10> Entities10 { get; set; }
    public DbSet<Entity11> Entities11 { get; set; }
    public DbSet<Entity12> Entities12 { get; set; }
    public DbSet<Entity13> Entities13 { get; set; }
    public DbSet<Entity14> Entities14 { get; set; }
    
    public DataContext()
    {
    }

    public void Migrate()
    {
        Database.Migrate();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=poc-test-8457.8nj.cockroachlabs.cloud;Port=26257;Database=defaultdb;Username=ruslan;Password=your pass here");
    }
}