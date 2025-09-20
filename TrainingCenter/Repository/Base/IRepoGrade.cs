using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoGrade : IRepository<Grade>
    {

        IEnumerable<Grade> FindAllGrade();



    }

}
