namespace Day02.OneToOnePP.Models
{
    public class Instructor
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Name { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Instructor_Car
        public virtual Instructor_Car? Instructor_Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
