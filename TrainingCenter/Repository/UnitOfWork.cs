using TrainingCenter.Data;
using TrainingCenter.Repository.Base;
using TrainingCenter.Models;


namespace TrainingCenter.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Cuorses = new RepoCuorse(_context);
            Employees = new RepoEmployee(_context);
            Exams = new RepoExam(_context);
            Grades = new RepoGrade(_context);
            Lecturers = new RepoLecturer(_context);
            Students = new RepoStudent(_context);




        }


        public IRepoCuorse Cuorses { get; }
        public IRepoEmployee Employees { get; }
        public IRepoExam Exams { get; }
        public IRepoGrade Grades { get; }
        public IRepoLecturer Lecturers { get; }
        public IRepoStudent Students { get; }
    }

}
