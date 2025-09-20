using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoCuorse : IRepository<Cuorse>
    {

        IEnumerable<Cuorse> FindAllCuorse();

    }
 
}
