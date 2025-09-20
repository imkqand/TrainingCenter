using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoGrade : MainRepository<Grade>, IRepoGrade
    {

        private readonly ApplicationDbContext _context;

        public RepoGrade(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Grade> FindAllGrade()
        {
            IEnumerable<Grade> grades = _context.Grades.ToList();
            return grades;
        }

    }

}
