using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories.Interfaces;

public interface ICourseRepository
{
    Task AddAsync(Course course);
    Task<IEnumerable<Course>> GetCoursesAsync();
    Task<Course?> GetCourseByCourseNoAsync(int courseNo);
    Task<Course?> GetCourseByIdAsync(int id);
    void Update(Course course);
    void Delete(Course course);
    Task<bool> SaveAllChangesAsync();
}