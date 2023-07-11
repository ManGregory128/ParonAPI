using ParonAPI.Data;
using ParonAPI.Interfaces;
using ParonAPI.Models;

namespace ParonAPI.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly DataContext _context;
        public SchoolRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<School> GetSchools()
        {
            return _context.Schools.OrderBy(p => p.Id).ToList();
        }
    }
}
