using Day02.Project.Configration;
using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day02.Project.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02Project;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            //modelBuilder.Entity<Instructor>().Ignore(i => i.CoursesNo);

            #region Course => Old
            //modelBuilder.Entity<Course>()
            //    .HasKey(c => c.Crs_Id);

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Name)
            //    .HasMaxLength(50)
            //    .IsRequired();

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Crs_Description)
            //    .HasMaxLength(200)
            //    .IsRequired(false);
            #endregion

            #region Course => New
            modelBuilder.Entity<Course>(c =>
            {
                c.HasKey(c => c.Crs_Id);
                c.Property(c => c.Crs_Name)
                    .HasMaxLength(50)
                    .IsRequired();
                c.Property(c => c.Crs_Description)
                .HasMaxLength(200)
                .IsRequired(false);
            });
            #endregion

            // Configration Files
            //modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<Student>().HasQueryFilter(s => !s.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        public override int SaveChanges()
        {
            // Validation
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added || e.State == EntityState.Modified
                           select e.Entity;

            foreach (var item in entities)
            {
                // Validate
                var validationContext = new ValidationContext(item);
                Validator.ValidateObject(item, validationContext, true);
            }
            // Keep
            return base.SaveChanges();
        }
        /*------------------------------------------------------------------*/
        #region Tables
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        #endregion
        /*------------------------------------------------------------------*/
    }
}


// CreatedOn
// CreatedBy
// ModifiedOn
// ModifiedBy

// LastPPChangedAt
// LastPasswordChangedAt
// LastLoginDate