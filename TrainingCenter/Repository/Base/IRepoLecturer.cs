using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoLecturer : IRepository<Lecturer>
    {
        IEnumerable<Lecturer> FindAllLecturer();

    }

}
