using System.ComponentModel.DataAnnotations.Schema;

namespace ParonAPI.Models
{
    public class School
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Staff { get; set; } = null!;
        public List<Group> Groups { get; set; } = null!;
        
        public School(string name) { Name = name; }
    }
}
