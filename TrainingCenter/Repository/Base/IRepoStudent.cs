using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoStudent : IRepository<Student>
    {
        IEnumerable<Student> FindAllStudent();
    }

}
