using TrainingCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace TrainingCenter.Data
{

    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Cuorse> Cuorses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Grade> Grades { get;set; }
        public DbSet<Exam> Exams { get; set; }






    }
}

         

        
    

