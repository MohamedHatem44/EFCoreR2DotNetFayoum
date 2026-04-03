using Day02.DbMigrations.Context;
using Day02.DbMigrations.Models;

namespace Day02.DbMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            // Context 
            AppDbContext db = new AppDbContext();
            /*------------------------------------------------------------------*/
            #region Db Creation Migration Strategy
            // Adds a new migration.
            // Add-Migration <Name>

            // Updates the database to the last migration or to a specified migration.
            // Update-Database

            // Remove Migration => Removes the last migration.
            // Remove-Migration
            #endregion
            /*------------------------------------------------------------------*/
            #region Crud Operations
            //Department d1 = new Department
            //{
            //    DeptName = "IT"
            //};
            //db.Add(d1);
            //db.SaveChanges();
            //Employee e1 = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Age2 = 30,
            //    Age3 = 30,
            //    Salary = 50000,
            //    DepartmentId = 1

            //};
            //db.Add(e1);
            //db.SaveChanges();
            #endregion
            /*------------------------------------------------------------------*/
            #region TestGuids
            //var testGuid1 = new TestGuid
            //{ 
            //    Name = "Test Guid 1"
            //};
            //db.Add(testGuid1);
            //db.SaveChanges();
            //var testGuid2 = new TestGuid
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Test Guid 2"
            //};
            //db.Add(testGuid2);
            //db.SaveChanges();
            //var items = db.TestGuids.ToList();
            //foreach (var item in items)
            //{
            //    Console.WriteLine(item.Id);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
