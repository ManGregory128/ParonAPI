namespace ParonAPI.Models
{
    public class FeedPost
    {
        public User? User { get; set; }
        public string Username { get; set; }
        public DateTime DateTimePosted { get; set; } 
        public string PostText { get; set; }

        public FeedPost(string username, string postText)
        {
            this.Username = username;
            this.PostText = postText;
            this.DateTimePosted = DateTime.Now;
        }
    }
}
