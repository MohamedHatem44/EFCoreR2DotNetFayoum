using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Project.Models
{
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        // Using Data Annotations
        /*------------------------------------------------------------------*/
        [Key]
        public int Ins_Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)] // Data Annotations => Validation => ASP.NET
        public string Ins_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Ins_Desc { get; set; }

        [Range(1000, 9000)]
        [Column(TypeName = "decimal(8,2)")] // => Total 8 => 123456.78 
        public decimal Salary { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        /*------------------------------------------------------------------*/
        // Fluent API => ignore
        [NotMapped]
        public int CoursesNo { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Department
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department? Department { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Course
        public virtual ICollection<Course> Courses { get; set; }
            = new HashSet<Course>();
        /*------------------------------------------------------------------*/
        // Relation With Car
        public virtual Car? Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
