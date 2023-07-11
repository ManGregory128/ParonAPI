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

        [HttpGet("logoutMobile/{username}/{password}")]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        public IActionResult LogoutMobile(string username, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            bool logoutResult = _userRepository.LogoutMobile(username, password);
            return Ok(logoutResult);
        }
    }
}
