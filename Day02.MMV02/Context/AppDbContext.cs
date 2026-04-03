using Day02.MMV02.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.MMV02.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02MMV02;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Classes => Tables
        // Local Containers => DbSet<T>
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        /*------------------------------------------------------------------*/
    }
}
