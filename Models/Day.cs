namespace ParonAPI.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWorkDay { get; set; }
        public List<Date>? Dates { get; set; }
        public ScheduleItem ScheduleItem { get; set; } = null!;

        public Day(int id)
        {
            switch (id) {
                case 1:
                    Name = "Monday";
                    IsWorkDay = true;
                    break;
                case 2:
                    Name = "Tuesday";
                    IsWorkDay = true;
                    break;
                case 3:
                    Name = "Wednesday";
                    IsWorkDay = true;
                    break;
                case 4:
                    Name = "Thursday";
                    IsWorkDay = true;
                    break;
                case 5:
                    Name = "Friday";
                    IsWorkDay = true;
                    break;
                case 6:
                    Name = "Saturday";
                    IsWorkDay = false;
                    break;
                case 7:
                    Name = "Sunday";
                    IsWorkDay = false;
                    break;
                default:
                    Name = "INVALID";
                    IsWorkDay = false;
                    break;
            }
        }
    }
}
