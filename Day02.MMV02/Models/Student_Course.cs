using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.MMV02.Models
{
    //[PrimaryKey("StudentId", "CourseId")]
    public class Student_Course
    {
        /*------------------------------------------------------------------*/
        // Relation Student
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        /*------------------------------------------------------------------*/
        // Relation Course
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        /*------------------------------------------------------------------*/
        public int Grade { get; set; }
        /*------------------------------------------------------------------*/
    }
}
