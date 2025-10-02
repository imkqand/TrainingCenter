namespace TrainingCenter.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public string SubjectHours { get; set; }

        public int? CourseCode { get; set; }
        public Course? CourseID  { get; set; }

        // subjectHoures
       //fk coursecode frome entity course 
    }
}
