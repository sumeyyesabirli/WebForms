﻿using Microsoft.EntityFrameworkCore;
using WebProject.Entity;
using System.Configuration;

public class ApplicationDbContext : DbContext
{
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Aboutus> Aboutus { get; set; }
    public DbSet<Package> Packages { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
        optionsBuilder.UseNpgsql(connectionString);
    }
}
