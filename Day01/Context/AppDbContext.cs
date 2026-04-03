using Day01.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Day01.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        // 1- Use SqlServer
        // 2- Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d => d.Employees)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired(true);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .IsRequired(true);  

            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Classes => Tables
        // Local Containers => DbSet<T>
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        /*------------------------------------------------------------------*/
    }
}
