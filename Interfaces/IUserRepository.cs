using Microsoft.AspNetCore.Mvc;
using ParonAPI.Models;

namespace ParonAPI.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();

        bool LoginMobile(string username, string password);

        bool LogoutMobile(string username, string password);

        bool ChangePassword(string username, string oldPassword, string newPassword);
    }
}
