using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoStudent : MainRepository<Student>, IRepoStudent
    {

        private readonly ApplicationDbContext _context;

        public RepoStudent(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Student> FindAllStudent()
        {
            IEnumerable<Student> students = _context.Students.ToList();
            return students;
        }

    }

}
