using API_EF_JWT.Models;
using Microsoft.EntityFrameworkCore;

namespace API_EF_JWT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();
    }
}