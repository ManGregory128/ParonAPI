using ParonAPI.Data;
using ParonAPI.Models;

namespace ParonAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Users.Any())
            {
                var Users = new List<User>()
                {
                    new User("kitiAdmin", "admin", "test@example.com", 'a')
                    {
                        School = new School("Kiti"),
                        Firstname = "Admin-Kiti"
                    }
                };
                dataContext.Users.AddRange(Users);
                dataContext.SaveChanges();
            }
            if (!dataContext.Days.Any())
            {
                var Days = new List<Day>()
                {
                    new Day(1),
                    new Day(2),
                    new Day(3),
                    new Day(4),
                    new Day(5),
                    new Day(6),
                    new Day(7)
                };
                dataContext.Days.AddRange(Days);
                dataContext.SaveChanges();
            }
        }
    }
}
