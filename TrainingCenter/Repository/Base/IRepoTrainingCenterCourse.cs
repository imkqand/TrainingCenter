using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoTrainingCenterCourse : IRepository<TrainingCenterCourse>
    {
        IEnumerable<TrainingCenterCourse> FindAllTrainingCenterCourse();
    }
}
