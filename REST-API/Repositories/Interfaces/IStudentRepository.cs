using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.Entities;

namespace REST_API.Repositories.Interfaces;

public interface IStudentRepository
{
    Task AddAsync(Student student);
    Task<IEnumerable<Student>> GetStudentsAsync();
    Task<Student?> GetStudentByEmailAsync(string email);
    Task<Student?> GetStudentByIdAsync(int id);
    void Update(Student student);
    void Delete(Student student);
    Task<bool> SaveAllChangesAsync();
}