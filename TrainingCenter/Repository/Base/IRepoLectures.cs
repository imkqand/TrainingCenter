using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoLectures : IRepository<Lectures>
    {
        IEnumerable<Lectures> FindAllLectures();
    }

}
