using System.ComponentModel.DataAnnotations.Schema;

namespace ParonAPI.Models
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public User TeacherRep { get; set; } = null!;
        public string? TeacherRepUsername { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; } = null!;
        public int SchoolId { get; set; }
        public School? School { get; set; }
        public List<Attendance> Attendances { get; set; } = null!;
        public List<Student> Students { get; set; } = null!;

        public Group(string name, int schoolId)
        {
            this.Name = name;
            this.SchoolId = schoolId;
        }
    }
}
