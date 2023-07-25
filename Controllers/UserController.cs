using Microsoft.AspNetCore.Mvc;
using ParonAPI.Interfaces;
using ParonAPI.Models;

namespace ParonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("loginMobile/{username}/{password}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult LoginMobile(string username, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            bool loginResult = _userRepository.LoginMobile(username, password);
            return Ok(loginResult);
        }

        [HttpGet("loginDesktop/{username}/{password}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult LoginDesktop(string username, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            char loginResult = _userRepository.LoginDesktop(username, password);
            return Ok(loginResult);
        }

        [HttpGet("logout/{username}/{password}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult Logout(string username, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            bool logoutResult = _userRepository.Logout(username, password);
            return Ok(logoutResult);
        }

        [HttpGet("changePassword/{username}/{oldPassword}/{newPassword}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            bool result = _userRepository.ChangePassword(username, oldPassword, newPassword);
            return Ok(result);
        }
    }
}
