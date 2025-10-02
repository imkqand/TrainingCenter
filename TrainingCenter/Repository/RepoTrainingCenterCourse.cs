using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoTrainingCenterCourse : MainRepository<TrainingCenterCourse>, IRepoTrainingCenterCourse
    {

        private readonly ApplicationDbContext _context;

        public RepoTrainingCenterCourse(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<TrainingCenterCourse> FindAllTrainingCenterCourse()
        {
            IEnumerable<TrainingCenterCourse> Emp = _context.trainingCenterCourses.ToList();
            return Emp;
        }

    }
    
   
}


