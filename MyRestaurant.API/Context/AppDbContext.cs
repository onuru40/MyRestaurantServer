using Microsoft.EntityFrameworkCore;
using MyRestaurant.API.Entities;

namespace MyRestaurant.API.Context
{
    public class AppDbContext(DbContextOptions options): DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}
