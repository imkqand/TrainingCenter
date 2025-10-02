using TrainingCenter.Models;

namespace TrainingCenter.Repository.Base
{
    public interface IRepoCourse : IRepository<Course>
    {
        IEnumerable<Course> FindAllCourses();
    }
 
}
