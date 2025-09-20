namespace TrainingCenter.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int? StudentId { get; set; }

        public string? ExamName { get; set; }
        public int? ExamId { get; set; }
       
    }
}
