using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoEmployee : IRepository<Employee>
    {

        IEnumerable<Employee> FindAllEmployee();



    }
}

