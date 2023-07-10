using System.ComponentModel.DataAnnotations.Schema;

namespace ParonAPI.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public School? School { get; set; }
        public int SchoolId { get; set; }
        public Group? Group { get; set; }
        public int GroupId { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string? ThirdName { get; set; }
        public string? ThirdRole { get; set; }
        public int MotherPhone { get; set; }
        public int FatherPhone { get; set; }
        public int? ThirdPhone { get; set; }
        public List<Attendance> Attendances { get; set; } = null!;

        public Student(string firstName, string lastName, int schoolId, int groupId, 
            string motherName, string fatherName, int motherPhone, int fatherPhone)
        {
            FirstName = firstName;
            LastName = lastName;
            SchoolId = schoolId;
            GroupId = groupId;
            MotherName = motherName;
            FatherName = fatherName;
            MotherPhone = motherPhone;
            FatherPhone = fatherPhone;
        }
    }
}
