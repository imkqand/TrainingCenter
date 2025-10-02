namespace TrainingCenter.Models
{
    public class TrainingCenterCourse
    {
        public int Id { get; set; }

        public string? Supervisor { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? CourseId { get; set; }

        public Course? Course { get; set; }


        public int? SubjectID { get; set; } 
        public Subject? Subject { get; set; }    
        public int? LectuerID { get; set; }
        public Lectures? Lectures { get; set; }

        

    }
}


