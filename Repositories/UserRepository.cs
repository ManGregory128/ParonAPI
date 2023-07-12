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

        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            var user = _context.Users.Where(p => p.Username == username && p.Password == oldPassword).FirstOrDefault();
            if (user == null) { return false; }
            user.Password = newPassword;
            _context.SaveChanges();
            return true;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(p => p.Username).ToList();
        }

        public bool LoginMobile(string username, string password)
        {
            var user = _context.Users.Where(p => p.Username == username && p.Password == password && p.Role == 't').FirstOrDefault();
            if (user == null) { return false; }
            if (user.Username == username && user.Password == password)
            { 
                user.IsLoggedIn = true;
                _context.SaveChanges();
                return true; 
            }
            return false;
        }
        public bool LogoutMobile(string username, string password)
        {
            var user = _context.Users.Where(p => p.Username == username && p.Password == password && p.Role == 't').FirstOrDefault();
            if (user == null) { return false; }
            if (user.Username == username && user.Password == password)
            {
                user.IsLoggedIn = false;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
