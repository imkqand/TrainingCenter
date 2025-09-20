using Microsoft.EntityFrameworkCore;
using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repository.Base;

namespace TrainingCenter.Repository
{
    public class RepoCuorse : MainRepository<Cuorse>, IRepoCuorse
    {

        private readonly ApplicationDbContext _context;

        public RepoCuorse(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



        public IEnumerable<Cuorse> FindAllCuorse()
        {
            IEnumerable<Cuorse> Cuorses = _context.Cuorses.ToList();
            return Cuorses;
        }

    }
}
