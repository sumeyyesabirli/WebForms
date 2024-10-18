using Microsoft.EntityFrameworkCore;
using WebProject.Entity;

public class ApplicationDbContext : DbContext
{
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Aboutus> Aboutus { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=GoTripDb;Username=postgres;Password=12345;\r\n");
    }
}
