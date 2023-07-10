using ParonAPI.Data;
using ParonAPI.Interfaces;
using ParonAPI.Models;

namespace ParonAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(p => p.Username).ToList();
        }
    }
}
