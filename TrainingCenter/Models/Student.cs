namespace TrainingCenter.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StudentId { get; set; }
      
        public string? Lecturers {  get; set; }
       
        public string? CourseName { get; set; }


        public string? ExamId {  get; set; }
        
        public decimal? Greades { get; set; }  


    }
}
