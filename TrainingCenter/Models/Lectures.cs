namespace TrainingCenter.Models
{
    public class Lectures
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int? Phone { get; set; }

        public int? CourseCode { get; set; }
        public Course? CourseID { get; set; }


    }
}
