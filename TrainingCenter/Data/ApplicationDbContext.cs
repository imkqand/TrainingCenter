using TrainingCenter.Models;
using Microsoft.EntityFrameworkCore;


namespace TrainingCenter.Data
{

    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
      

        //--------------Lectuer-------------------------
     
        public DbSet<Lectures> Lecturess { get; set; }
       // --------------- Exam---------------
       
      

        //------------------------------Subject----------------------------------
        
        public DbSet<Subject> subjects { get; set; }




        //----------------Courses-------------------------------------------
       
        public DbSet<TrainingCenterCourse> trainingCenterCourses { get; set; }

        
        public DbSet<Course> courses { get; set; }

        //----------------------------student---------------------------

        public DbSet<Student> students { get; set; }





    }
}

         

        
    

