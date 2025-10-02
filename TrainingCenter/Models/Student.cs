namespace TrainingCenter.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Rank { get; set; }
        public int? EmpId { get; set; }
        public string? Department { get; set; }
        public int? CourseCode { get; set; }
        public Course? Course { get; set; }
    }
}
