using Microsoft.EntityFrameworkCore;
using MIS.Data.Models;

namespace MIS.Data.Contexts
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
