using System.ComponentModel.DataAnnotations.Schema;

namespace ParonAPI.Models
{
    public class Semester
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Date>? Dates { get; set; }
    }
}
