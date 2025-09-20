using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoEmployee : MainRepository<Employee>, IRepoEmployee
    {

        private readonly ApplicationDbContext _context;

        public RepoEmployee(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Employee> FindAllEmployee()
        {
            IEnumerable<Employee> Emp = _context.Employees.ToList();
            return Emp;
        }

    }


}
