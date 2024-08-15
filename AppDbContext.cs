using Microsoft.EntityFrameworkCore;
using NunesSportsAPI.Models;

namespace NunesSportsAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


    }
}
