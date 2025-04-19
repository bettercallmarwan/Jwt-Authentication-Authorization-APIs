using JwtAuthenticationProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace JwtProject.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; } 
    }
}
