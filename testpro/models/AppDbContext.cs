using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace testpro.models
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(Entry => { Entry.HasMany<Post>().WithOne(p => p.Users).HasForeignKey(p => p.Id).OnDelete(DeleteBehavior.Restrict); });
        }
        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }
    }
}
