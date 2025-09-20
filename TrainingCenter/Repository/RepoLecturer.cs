using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoLecturer : MainRepository<Lecturer>, IRepoLecturer
    {

        private readonly ApplicationDbContext _context;

        public RepoLecturer(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Lecturer> FindAllLecturer()
        {
            IEnumerable<Lecturer> Lect = _context.Lecturers.ToList();
            return Lect;
        }

    }
}
