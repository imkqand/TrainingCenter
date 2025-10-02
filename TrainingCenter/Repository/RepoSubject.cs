using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoSubject : MainRepository<Subject>, IRepoSubject
    {

        private readonly ApplicationDbContext _context;

        public RepoSubject(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Subject> FindAllSubject()
        {
            IEnumerable<Subject> Emp = _context.subjects.ToList();
            return Emp;
        }

    }

}
