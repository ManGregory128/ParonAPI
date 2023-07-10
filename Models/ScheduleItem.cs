namespace ParonAPI.Models
{
    public class ScheduleItem
    {
        public Period? Period { get; set; }
        public Lesson? Lesson { get; set; }
        public User? Teacher { get; set; }
        public Day? Day { get; set; }
        public Group? Group { get; set; }

        public int PeriodId { get; set; }
        public int LessonId { get; set; }
        public string TeacherUsername { get; set; }
        public int DayId { get; set; }
        public int GroupId { get; set; }

        public ScheduleItem(int periodId, int lessonId, int dayId, int groupId, string teacherUsername)
        {
            PeriodId = periodId;
            LessonId = lessonId;
            DayId = dayId;
            GroupId = groupId;
            TeacherUsername = teacherUsername;
        }
    }
}
