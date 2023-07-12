using ParonAPI.Models;

namespace ParonAPI.Interfaces
{
    public interface IFeedPostRepository
    {
        ICollection<FeedPost> GetFeedPosts();
        bool CreatePost(string username, string password, string text);
    }
}
