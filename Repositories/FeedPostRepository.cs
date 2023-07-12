using ParonAPI.Data;
using ParonAPI.Interfaces;
using ParonAPI.Models;

namespace ParonAPI.Repositories
{
    public class FeedPostRepository : IFeedPostRepository
    {
        private readonly DataContext _context;
        public FeedPostRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreatePost(string username, string password, string text)
        {
            var user = _context.Users.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
            if (user == null) { return false; }
            FeedPost newPost = new FeedPost(username, text);
            _context.FeedPosts.Add(newPost);
            _context.SaveChanges();
            return true;
        }

        public ICollection<FeedPost> GetFeedPosts()
        {
            return _context.FeedPosts.OrderBy(p => p.DateTimePosted).ToList();
        }
    }
}
