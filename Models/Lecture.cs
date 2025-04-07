namespace Courseprogram.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
