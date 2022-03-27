using REST_API.Services.Interfaces;
using REST_API.Repositories.Interfaces;
using REST_API.Entities;

namespace REST_API.Services;

//This class provides another layer...
public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepo;
    public CourseService(ICourseRepository courseRepo)
    {
        _courseRepo = courseRepo;
    }

    public async Task<IEnumerable<Course>> GetAllCoursesAsync() => await _courseRepo.GetCoursesAsync();

}