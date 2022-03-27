using REST_API.Entities;

namespace REST_API.Services.Interfaces;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetAllCoursesAsync();
    
}