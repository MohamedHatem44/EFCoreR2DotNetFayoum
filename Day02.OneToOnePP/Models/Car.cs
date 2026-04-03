namespace Day02.OneToOnePP.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        /*------------------------------------------------------------------*/
        // Relation With Instructor_Car
        public virtual Instructor_Car? Instructor_Car { get; set; }
        /*------------------------------------------------------------------*/
    }
}
