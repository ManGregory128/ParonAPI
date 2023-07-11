using ParonAPI.Models;

namespace ParonAPI.Interfaces
{
    public interface ISchoolRepository
    {
        ICollection<School> GetSchools();
    }
}
