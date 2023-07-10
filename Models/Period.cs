namespace ParonAPI.Models
{
    public class Period
    {
        public int Id { get; set; }
        public bool CanBeDouble { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; } = null!;
        public List<Attendance> Attendances { get; set; } = null!;
    }
}
