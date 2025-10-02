namespace TrainingCenter.Repository.Base
{
    public interface IUnitOfWork
    {
     
        IRepoTrainingCenterCourse TrainingCenterCourse { get; }
        IRepoCourse Courses { get; }
        IRepoSubject Subjectts { get; }
        IRepoLectures Lecture { get; }
        IRepoStudent Students { get; }
        void Save();
    }
}
