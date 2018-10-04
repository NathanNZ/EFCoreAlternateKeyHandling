using ConsoleApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    public class TestContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EFCoreTestContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
            

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userTasks = modelBuilder.Entity<UserTask>();

            userTasks.HasKey(e => new { e.ExternalTaskId, e.ExternalUserId });

            userTasks.HasOne(e => e.User)
                 .WithMany(e => e.UserTasks)
                 .HasForeignKey(e => e.ExternalUserId)
                 .HasPrincipalKey(e => e.ExternalId);

            userTasks.HasOne(e => e.Task)
                 .WithMany(e => e.UserTasks)
                 .HasForeignKey(e => e.ExternalTaskId)
                 .HasPrincipalKey(e => e.ExternalId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> ExternalUser { get; set; }
    }
}
