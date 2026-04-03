using Day02.DbMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.DbMigrations.Context
{
    public class AppDbContext : DbContext
    {
        /*------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MOHAMED-HATEM\\SQLEXPRESS;DataBase=DotNetFayoumDay02;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        /*------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seeding
            var departments = new List<Department>()
            {
                new Department { Id = 1, DeptName = "IT" },
                new Department { Id = 2, DeptName = "HR" },
                new Department { Id = 3, DeptName = "Sales" },
                new Department { Id = 4, DeptName = "Finance" },
            };

            var employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234, DepartmentId = 3 },
                new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234, DepartmentId = 4 },
                new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234, DepartmentId = 1 },
                new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234, DepartmentId = 2 },
                new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234, DepartmentId = 3 },
                new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234, DepartmentId = 4 },
                new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234, DepartmentId = 1 },
                new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234, DepartmentId = 4 },
            };

            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<Employee>().HasData(employees);
            base.OnModelCreating(modelBuilder);
        }
        /*------------------------------------------------------------------*/
        // Classes => Tables
        // Local Containers => DbSet<T>
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<TestGuid> TestGuids { get; set; }
        /*------------------------------------------------------------------*/
    }
}
