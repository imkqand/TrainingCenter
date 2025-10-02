using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoSubject : IRepository<Subject>
    {
        IEnumerable<Subject> FindAllSubject();
    }

}
