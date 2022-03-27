using REST_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace REST_API.Data;

public class DataContext : DbContext
{
    public DataContext (DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Student> Students => Set<Student>();
}