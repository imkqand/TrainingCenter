using TrainingCenter.Data;
using TrainingCenter.Repository.Base;
using TrainingCenter.Models;


namespace TrainingCenter.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
          
            TrainingCenterCourse = new RepoTrainingCenterCourse(_context);
            Subjectts = new RepoSubject(_context);
            Courses = new RepoCourse(_context);
            Lecture = new RepoLectures(_context);
            Students = new RepoStudent (_context);
        }


 

        public IRepoTrainingCenterCourse TrainingCenterCourse { get; }
        public IRepoSubject Subjectts { get; }
        public IRepoCourse Courses { get; }
        public IRepoLectures Lecture { get; }
        public IRepoStudent Students { get; }



        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
