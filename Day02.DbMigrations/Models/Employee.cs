using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.DbMigrations.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public int Age2 { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        public int DepartmentId { get; set; }
        // Navigation property to Department
        // References the Department object associated with this Employee
        // Assosiation
        public Department Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DepartmentId: {DepartmentId}";
        }
        /*------------------------------------------------------------------*/
    }
}
