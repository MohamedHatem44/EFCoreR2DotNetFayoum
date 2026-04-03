using Day02.MMV01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.MMV01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02MMV01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Post>()
            //    .HasMany(e => e.Tags)
            //    .WithMany(e => e.Posts)
            //    .UsingEntity(
            //        "PostTag",
            //        r => r.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Tag.Id)),
            //        l => l.HasOne(typeof(Post)).WithMany().HasForeignKey("PostsId").HasPrincipalKey(nameof(Post.Id)),
            //        j => j.HasKey("PostsId", "TagsId"));
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Classes => Tables
        // Local Containers => DbSet<T>
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        /*------------------------------------------------------------------*/
    }
}
