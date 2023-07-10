using System.ComponentModel.DataAnnotations.Schema;

namespace ParonAPI.Models
{
    public class Lesson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ScheduleItem ScheduleItem { get; set; } = null!;

        public Lesson(string name)
        {
            this.Name = name;
        }
    }
}
