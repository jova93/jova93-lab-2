using System.Collections.Generic;
using System.Threading.Tasks;
using REST_API.Entities;
using REST_API.Data;
using REST_API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace REST_API.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly DataContext _context;
    public StudentRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Student student)
    {
        await _context.Students.AddAsync(student);
    }

    public void Delete(Student student)
    {
        _context.Students.Remove(student);
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await _context.Students.Include(c => c.Course).SingleOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Student?> GetStudentByEmailAsync(string studentEmail)
    {
        var student = await _context.Students.Include(c => c.Course).SingleOrDefaultAsync(c => c.Email!.ToLower() == studentEmail.ToLower());

        return student;
    }

    public async Task<IEnumerable<Student>> GetStudentsAsync()
    {
        return await _context.Students.Include(c => c.Course).ToListAsync();
    }

    public async Task<bool> SaveAllChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Update(Student student)
    {
        _context.Students.Update(student);
    }
}