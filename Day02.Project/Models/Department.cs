namespace Day02.Project.Models
{
    public class Department
    {
        /*------------------------------------------------------------------*/
        // EF Conventions
        /*------------------------------------------------------------------*/
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Student
        public virtual ICollection<Student> Students { get; set; }
        = new HashSet<Student>();
        /*------------------------------------------------------------------*/
        // Relation With Instructor
        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();
        /*------------------------------------------------------------------*/
    }
}
