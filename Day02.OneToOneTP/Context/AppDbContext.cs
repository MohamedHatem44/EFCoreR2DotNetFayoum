using Day02.OneToOneTP.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.OneToOneTP.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02OneToOneTP;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Car)
                .WithOne(c => c.Instructor)
                .HasForeignKey<Car>(c => c.InstructorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Car>()
            //    .HasOne(c => c.Instructor)
            //    .WithOne(i => i.Car)
            //    .HasForeignKey<Car>(c => c.InstructorId);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        /*------------------------------------------------------------------*/
    }
}
