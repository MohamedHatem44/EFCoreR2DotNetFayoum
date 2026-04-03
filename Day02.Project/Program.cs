using Day02.Project.Context;
using Day02.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------------------------------*/
            // Context 
            AppDbContext db = new AppDbContext();
            /*------------------------------------------------------------------*/
            //var q1 = db.Students.ToList();
            //var q2 = db.Students.First();
            //q2.StdName = $"Deleted:{q2.StdName}";
            //q2.IsDeleted = true;
            //var q3 = db.Students.IgnoreQueryFilters().ToList();
            /*------------------------------------------------------------------*/
            //var instructor = new Instructor
            //{
            //    Ins_Name = "MMM",
            //    Ins_Desc = "Senior Instructor",
            //    Salary = 5000,
            //    Email = "MM@mail.com"
            //};
            //db.Add(instructor);
            //db.SaveChanges();
            /*------------------------------------------------------------------*/
        }
    }
}
