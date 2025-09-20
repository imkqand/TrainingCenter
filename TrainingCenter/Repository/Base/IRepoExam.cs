using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoExam : IRepository<Exam>
    {
        IEnumerable<Exam> FindAllExam();
    }

}
