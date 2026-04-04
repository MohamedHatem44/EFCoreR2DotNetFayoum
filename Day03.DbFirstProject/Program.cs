using Day03.DbFirstProject.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Day03.DbFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            // Context
            PubsDbContext db = new PubsDbContext();
            /*------------------------------------------------------------------*/
            //var employees = db.employees.ToList();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.fname);
            //}
            /*------------------------------------------------------------------*/
            #region Tracking
            // EF Core By Dafult Track records that are retrieved from the database
            // and any changes made to them, so that it can automatically generate
            // the appropriate SQL statements to update the database when you call
            // SaveChanges().
            // Use Local To Retrive Records
            // Save DB Overhead

            //var employee = db.employees.FirstOrDefault();
            //db.ChangeTracker.Clear();
            //employee.fname = "Ahmed New 2 ";
            //db.SaveChanges();

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine(db.employees.Count()); // 43
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine(db.employees.Local.Count()); // 0
            //Console.WriteLine("-------------------------------");
            //var employees2 = db.employees;
            //Console.WriteLine(db.employees.Local.Count()); // 43

            //Console.WriteLine("-------------------------------");
            //var employees3 = db.employees.ToList();
            //Console.WriteLine(db.employees.Local.Count()); // 43
            //Console.WriteLine("-------------------------------");
            //var employees4 = db.employees.Where(e => e.job_lvl < 100).ToList();
            //Console.WriteLine(employees4.Count());
            //Console.WriteLine(db.employees.Local.Count()); // 12

            //db.ChangeTracker.Clear(); // Clear the Change Tracker to remove all tracked entities from memory

            //Console.WriteLine("-------------------------------");
            //var employees5 = db.employees.Where(e => e.job_lvl >= 100).ToList();
            //Console.WriteLine(employees5.Count()); // 31 
            //Console.WriteLine(db.employees.Local.Count()); // 31

            // Get All => No Tracking
            // Get One => Tracking

            //var employee = db.employees.FirstOrDefault();
            //employee.fname = "Ahmed New 2 ";
            //db.SaveChanges();

            //var employees6 = db.employees.AsNoTracking().ToList();
            //Console.WriteLine(employees6.Count());  // 43
            //Console.WriteLine(db.employees.Local.Count()); // 0
            #endregion
            /*------------------------------------------------------------------*/
            #region Find
            //// Return Single Record by Primary Key
            //// Find(PK[])
            //// By Default
            //// Search In Memory First if Found Return It
            //// If Not found connect to db and return element and start tracking it
            //// If not found in DB return null and no exception will be thrown


            //// exec sp_executesql N'SELECT TOP(1) [e].[emp_id], [e].[fname],
            //// [e].[hire_date], [e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            //// FROM[employee] AS[e]
            //// WHERE[e].[emp_id] = @__p_0',N'@__p_0 char(9)',@__p_0='PMA42628M'
            //// go
            //var employees = db.employees.AsNoTracking().ToList();

            //var id = "PMA42628Mwww";
            //var employee = db.employees.Find(id);
            //if(employee != null)
            //{
            //    Console.WriteLine(employee.fname);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion
            /*------------------------------------------------------------------*/
            #region Explicit Loading
            //// Load Data First Request
            //Console.WriteLine(db.employees.Local.Count()); // 0

            //db.employees.Local.Clear(); // Clear the Local collection to remove any previously loaded entities
            //db.employees.Load(); // Explicit Loading

            //Console.WriteLine(db.employees.Local.Count()); // 43
            #endregion
            /*------------------------------------------------------------------*/
            #region AsQueryable vs AsEnumerable
            //// AsQueryable
            //// Execute Query in DB Server
            //// Filter Data in DB Server
            //// System.Linq.Queryable

            //// AsEnumerable
            //// Execute Filter Data in Memory
            //// System.Collections.Generic.IEnumerable

            //Console.WriteLine("------------------------------------------");
            //////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            //////[e].[job_id], [e].[job_lvl],
            //////[e].[lname], [e].[minit], [e].[pub_id]
            //////FROM[employee] AS[e]
            //var q1 = db.employees.AsEnumerable();
            //var q1F = q1.Where(e => e.job_lvl < 100).ToList();
            //foreach (var item in q1F)
            //{
            //    Console.WriteLine(item.fname);
            //}
            //Console.WriteLine("------------------------------------------");
            ////SELECT[e].[emp_id], [e].[fname], [e].[hire_date],
            ////[e].[job_id], [e].[job_lvl], [e].[lname], [e].[minit], [e].[pub_id]
            ////FROM[employee] AS[e]
            ////WHERE[e].[job_lvl] < CAST(100 AS tinyint)
            //var q2 = db.employees.AsQueryable();
            //var q2F = q2.Where(e => e.job_lvl < 100).ToList();
            ////if(category != null)
            //{
            //    //query = query.where(category = laptop)
            //}
            //foreach (var item in q2F)
            //{
            //    Console.WriteLine(item.fname);
            //}
            //Console.WriteLine("------------------------------------------");
            #endregion
            /*------------------------------------------------------------------*/
            #region Bulk Update and Bulk Delete
            //// Bulk Update
            //db.employees
            //    .Where(e => e.job_lvl < 100)
            //    .ExecuteUpdate(s =>
            //    s.SetProperty(e => e.job_lvl, e => e.job_lvl + 10)
            //    //.SetProperty.
            //    );

            //// Bulk Delete
            //db.employees
            //    .Where(e => e.job_lvl < 100)
            //    .ExecuteDelete();
            #endregion
            /*------------------------------------------------------------------*/
            #region SQL Query
            //// select * from authors

            ////var q1 = db.authors.FromSqlRaw("SELECT * FROM authors").ToList();
            ////var q2 = db.authors.FromSqlRaw("SELECT * FROM authors").OrderBy(a=>a.au_fname).ToList();

            //var id = "172-32-1176";
            //var q3 = db.authors.FromSqlRaw($"SELECT * FROM authors where au_id = '{id}'").ToList();

            //// exec sp_executesql N'SELECT * FROM authors where au_id = @id
            ////',N'@id nvarchar(11)',@id=N'172 - 32 - 1176'
            //var q4 = db.authors.FromSqlRaw($"SELECT * FROM authors where au_id = @id", new SqlParameter("@id", id)).ToList();

            //var q5 = db.authors.FromSqlInterpolated($"SELECT * FROM authors where au_id = {id}").ToList();

            //var q6 = db.authors.FromSqlRaw("exec getallauthors").ToList();
            //var q6_1 = q6.OrderBy(a => a.au_fname).ToList();

            //// SP Can't Encapulate into another query
            //var q7 = db.authors.FromSqlRaw("exec getallauthors").OrderBy(a => a.au_fname).ToList();
            //foreach (var item in q6_1)
            //{
            //    Console.WriteLine(item.au_fname);
            //}
            #endregion
            /*------------------------------------------------------------------*/
        }
    }
}
