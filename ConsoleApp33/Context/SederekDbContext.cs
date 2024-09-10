using ConsoleApp33.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp33.Context;

public class SederekDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0116-01;Initial Catalog = SederekDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasKey(c => c.Nazim);
        //modelBuilder.Entity<Product>(entity =>
        //{
        //    entity.Property(p => p.Name).HasColumnName("ProductName");
        //});
        //modelBuilder.Entity<Product>().Ignore(p=>p.Name);


        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Name).HasMaxLength(20);
        });
        base.OnModelCreating(modelBuilder);



    }
}
