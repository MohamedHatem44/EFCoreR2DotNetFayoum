using Day01.Context;
using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            // Context 
            AppDbContext db = new AppDbContext();
            /*------------------------------------------------------------------*/
            #region Db Creation Strategy
            // 1- EnsureCreated
            // 2- Migration

            // Dev Only
            // EnsureDeleted
            // ensures that the database for the context does not exist.
            // If it does not exist, no action is taken.
            // If it does exist then the database is deleted.
            //db.Database.EnsureDeleted();

            // EnsureCreated
            // • If the database exists and has any tables, then no action is taken. Nothing
            // is done to ensure the database schema is compatible with the Entity Framework
            // model.
            // • If the database exists but does not have any tables, then the Entity Framework
            // model is used to create the database schema.
            // • If the database does not exist, then the database is created and the Entity
            // Framework model is used to create the database schema.
            //db.Database.EnsureCreated();
            #endregion
            /*------------------------------------------------------------------*/
            #region Employee
            //Employee e1 = new Employee
            //{
            //    Name = "Mohamed",
            //    Age = 30,
            //    Salary = 5000
            //};

            //// Add Employee to Local Container
            ////db.Employees.Add(e1);
            //db.Add(e1);

            //// Affect To Database
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Department
            //Department d1 = new Department
            //{
            //    DeptName = "IT"
            //};

            //db.Add(d1);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Between Employee and Department
            //// V01
            //Employee e1 = new Employee
            //{
            //    Name = "Mohamed",
            //    Age = 30,
            //    Salary = 5000,
            //    DepartmentId = 1
            //};

            //// Add Employee to Local Container
            ////db.Employees.Add(e1);
            //db.Add(e1);

            //// Affect To Database
            //db.SaveChanges();

            //// V02
            //var department = db.Departments.FirstOrDefault();

            //Employee e2 = new Employee
            //{
            //    Name = "Mohamed",
            //    Age = 30,
            //    Salary = 5000,
            //    Department = department
            //};

            //// Add Employee to Local Container
            ////db.Employees.Add(e2);
            //db.Add(e2);

            //// Affect To Database
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Relation Between Employee and Department With Shadow FK
            //var department = db.Departments.FirstOrDefault();

            //Employee e3 = new Employee
            //{
            //    Name = "Mohamed",
            //    Age = 30,
            //    Salary = 5000,
            //    Department = department
            //};

            //// Add Employee to Local Container
            ////db.Employees.Add(e3);
            //db.Add(e3);

            //// Affect To Database
            //db.SaveChanges();


            //Employee e4 = new Employee
            //{
            //    Name = "Mohamed",
            //    Age = 30,
            //    Salary = 5000,
            //    DepartmenntId = 1
            //};

            //// Add Employee to Local Container
            ////db.Employees.Add(e4);
            //db.Add(e4);

            //// Affect To Database
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region Crud
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            #region Add Departments
            //Department d1 = new Department { DeptName = "IT" };
            //Department d2 = new Department { DeptName = "UI" };
            //Department d3 = new Department { DeptName = "SD" };
            //Department d4 = new Department { DeptName = "Mob" };
            //Department d5 = new Department { DeptName = "OS" };

            ////db.AddRange(new Department[] { d1, d2, d3, d4, d5 });
            //db.AddRange(d1, d2, d3, d4, d5);
            //db.SaveChanges(); 
            #endregion

            #region Add Employees
            //Employee e1 = new Employee { Name = "Mohamed", Age = 30, Salary = 5000, DepartmentId = 1 };
            //Employee e2 = new Employee { Name = "Ahmed", Age = 25, Salary = 4000, DepartmentId = 2 };
            //Employee e3 = new Employee { Name = "Sara", Age = 28, Salary = 4500, DepartmentId = 3 };
            //Employee e4 = new Employee { Name = "Laila", Age = 32, Salary = 5500, DepartmentId = 4 };
            //Employee e5 = new Employee { Name = "Omar", Age = 27, Salary = 4200, DepartmentId = 5 };

            //db.AddRange(e1, e2, e3, e4, e5);
            //db.SaveChanges();
            #endregion

            #region Get Employees
            //// SELECT [e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            //// FROM[Employees] AS[e]
            //var allEmployees1 = db.Employees;
            //foreach (var item in allEmployees1)
            //{
            //    Console.WriteLine(item);
            //}

            //// SELECT TOP(1) [e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name], [e].[Salary]
            //// FROM[Employees] AS[e]
            //var employee = db.Employees.FirstOrDefault();
            //Console.WriteLine(employee);

            //// Eager Loading
            //// SELECT[e].[Id], [e].[Age], [e].[DepartmentId], [e].[Name],
            //// [e].[Salary], [d].[Id], [d].[DeptName]
            //// FROM[Employees] AS[e]
            //// INNER JOIN[Departments] AS[d] ON[e].[DepartmentId] = [d].[Id]
            //var allEmployees2 = db.Employees.Include(e => e.Department);
            //foreach (var item in allEmployees2)
            //{
            //    Console.WriteLine(item);
            //}

            //// Lazy Loading
            //// N + 1 Problem
            //var allEmployees3 = db.Employees.ToList();
            //// There is already an open DataReader associated with this Connection which must be closed first.
            //foreach (var item in allEmployees3)
            //{
            //    Console.WriteLine(item.Department);
            //}
            #endregion

            #region Update
            //// V01
            //var employeeToUpdate1 = new Employee
            //{
            //    Id = 1,
            //    Name = "Updated 2",
            //    DepartmentId = 2
            //};
            //db.Update(employeeToUpdate1);
            //db.SaveChanges();

            //// V02 => Recommended
            //// 1- Catch The Old Data From Database
            //var employeeToUpdate1 = db.Employees.FirstOrDefault(e => e.Id == 2);
            //if (employeeToUpdate1 != null)
            //{
            //    // 2- Update The Properties That I Need To Update
            //    employeeToUpdate1.Name = "Updated 2";
            //    db.SaveChanges();
            //}
            #endregion

            #region Delete
            //var employeeToDelete = db.Employees.FirstOrDefault(e => e.Id == 5);
            //if (employeeToDelete != null)
            //{
            //    db.Remove(employeeToDelete);
            //    db.SaveChanges();
            //}
            #endregion
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
