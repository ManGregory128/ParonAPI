namespace ParonAPI.Models
{
    public class Attendance
    {
        public Date? Date { get; set; }
        public Period? Period { get; set; }
        public Student? Student { get; set; }
        public Group? Group { get; set; }
        public bool IsPresent { get; set; }
        public DateTime DateId { get; set; }
        public int PeriodId { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }
    }
}
