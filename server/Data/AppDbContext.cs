using Microsoft.EntityFrameworkCore;
using OneBottle.Models;

namespace OneBottle.Data{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users{ get; set; }
    } }