using DemoProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Infrastructure.EFCore;

public class AppDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=Pb304OnionDb;Trusted_Connection=True;TrustServerCertificate=true");
    }
}
