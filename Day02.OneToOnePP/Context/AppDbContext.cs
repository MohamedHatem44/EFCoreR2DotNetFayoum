using Day02.OneToOnePP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.OneToOnePP.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02OneToOnePP;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor_Car>()
                .HasKey(ic => new { ic.InstructorId, ic.CarId });

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Instructor_Car> Instructor_Cars { get; set; }
        /*------------------------------------------------------------------*/
    }
}
