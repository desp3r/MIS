using Microsoft.EntityFrameworkCore;
using MIS.API.Data.Models;

namespace MIS.API.Data.Contexts
{
    public class MisContext : DbContext
    {
        public MisContext(DbContextOptions<MisContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
