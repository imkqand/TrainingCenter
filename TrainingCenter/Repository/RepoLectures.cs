using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoLectures : MainRepository<Lectures>, IRepoLectures
    {

        private readonly ApplicationDbContext _context;

        public RepoLectures(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Lectures> FindAllLectures()
        {
            IEnumerable<Lectures> Emp = _context.Lecturess.ToList();
            return Emp;
        }

    }
}
