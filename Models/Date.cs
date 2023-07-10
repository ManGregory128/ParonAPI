namespace ParonAPI.Models
{
    public class Date
    {
        public DateTime Id { get; set; }
        public Semester Semester { get; set; } = null!;
        public Day Day { get; set; } = null!;
        public int SemesterId { get; set; }
        public int DayId { get; set; }
        public bool IsHoliday { get; set; }
        public string? HolidayName { get; set; }
        public List<Attendance> Attendances { get; set; } = null!;
    }
}
