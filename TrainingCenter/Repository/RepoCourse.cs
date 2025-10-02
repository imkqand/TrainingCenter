using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoCourse : MainRepository<Course>, IRepoCourse
    {

        private readonly ApplicationDbContext _context;

        public RepoCourse(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Course> FindAllCourses()
        {
            IEnumerable<Course> Emp = _context.courses.ToList();
            return Emp;
        }

    }

}
   

