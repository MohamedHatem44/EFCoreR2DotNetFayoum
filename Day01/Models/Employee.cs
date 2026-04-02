// How To Wirte Model Class With EF RunTime
// 1- EF Conventions
// 2- DataAnnotaions    => System.ComponentModel.DataAnnotations;
// 3- Fluent API        => OnModelCreating => Context
// 4- External Class Configration => External Files And Call it into OnModelCreating => Context


// EF Conventions
// 1- PK => Primitive int Id , ClassNameId, EmployeeId => PK
// 2- PK => Identity
// 3- Any Value Type By Default => Not Null
// 3- Any Reference Type By Default => Null
// 4- String => nvarcharmax(max) 2G
// 5- Default Relation => One To Many

// Before C# 8
// Reference Null
// After C#
// Non-Nullable
// Fire Warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day01.Models
{
    // Domain Class => Model Class => Entity Class => Table
    public class Employee
    {
        /*------------------------------------------------------------------*/
        [Key]
        public int Id { get; set; }

        [Required]
        //[MaxLength(50)]
        [StringLength(50)]
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        //[ForeignKey("Department")]
        //[ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        // Navigation property to Department
        // References the Department object associated with this Employee
        // Association

        //[ForeignKey(nameof(DepartmentId))]
        //[ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        /*------------------------------------------------------------------*/
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DepartmentId}, Department => {Department} <=";
        }
        /*------------------------------------------------------------------*/
    }
}

// public int DepartmentId { get; set; } => Required Relation
// public int? DepartmentId { get; set; } => Non Required Relation