using System.Globalization;

namespace ParonAPI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public char Role { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public bool IsLoggedIn { get; set; }
        public School? School { get; set; }
        public int? SchoolId { get; set; }
        public List<FeedPost> FeedPosts { get; set; } = null!;
        public List<ScheduleItem> ScheduleItems { get; set; } = null!;
        public Group? Group { get; set; }

        public User(string username, string password, string email, char role)
        {
            IsLoggedIn = false;
            Username = username;
            Password = password;
            Email = email;
            Role = role;
        }
    }
}
