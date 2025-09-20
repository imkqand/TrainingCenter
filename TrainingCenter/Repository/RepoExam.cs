using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoExam : MainRepository<Exam>, IRepoExam
    {

        private readonly ApplicationDbContext _context;

        public RepoExam(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Exam> FindAllExam()
        {
            IEnumerable<Exam> Exa = _context.Exams.ToList();
            return Exa;
        }

    }

}
