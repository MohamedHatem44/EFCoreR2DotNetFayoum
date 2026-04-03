namespace Day02.SelfRelation.Models
{
    public class Employee
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Manager
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Employees
        public virtual ICollection<Employee> Subordinates { get; set; }
            = new HashSet<Employee>();
        /*------------------------------------------------------------------*/
    }

    //public class Manager
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public decimal Salary { get; set; }
    //    // Relation With Employees
    //    public virtual ICollection<Employee> Subordinates { get; set; }
    //        = new HashSet<Employee>();
    //}
}
