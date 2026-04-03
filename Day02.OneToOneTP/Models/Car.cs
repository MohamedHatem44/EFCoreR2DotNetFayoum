namespace Day02.OneToOneTP.Models
{
    public class Car
    {
        /*------------------------------------------------------------------*/
        public int Id { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        /*------------------------------------------------------------------*/
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        /*------------------------------------------------------------------*/
    }
}
