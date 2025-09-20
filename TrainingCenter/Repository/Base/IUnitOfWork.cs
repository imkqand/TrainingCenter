namespace TrainingCenter.Repository.Base
{
    public interface IUnitOfWork
    {
        IRepoCuorse Cuorses { get; }
        IRepoEmployee Employees { get; }
        IRepoExam Exams { get; }
        IRepoGrade Grades { get; }
        IRepoLecturer Lecturers { get; }
        IRepoStudent Students { get; }

        void Save();
    }
}
