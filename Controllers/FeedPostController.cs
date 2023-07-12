using Microsoft.AspNetCore.Mvc;
using ParonAPI.Dto;
using ParonAPI.Interfaces;
using ParonAPI.Models;
using ParonAPI.Repositories;

namespace ParonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedPostController : Controller
    {
        private readonly IFeedPostRepository _repository;

        public FeedPostController(IFeedPostRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<FeedPost>))]
        public IActionResult GetFeedPosts()
        {
            var posts = _repository.GetFeedPosts();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(posts);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult PostToFeed([FromQuery] string username, [FromQuery] string password, [FromBody] string postText)
        {
            if (username == null || password == null || postText == null)
                return BadRequest(ModelState);
            if (!_repository.CreatePost(username, password, postText))
            {
                ModelState.AddModelError("", "Error Creating Post: Credentials Incorrect");
                return StatusCode(500, ModelState);
            }
            return Ok("Successfully created");
        }
    }
}
