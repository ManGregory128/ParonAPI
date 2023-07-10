using ParonAPI.Models;

namespace ParonAPI.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
    }
}
