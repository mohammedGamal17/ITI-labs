using Microsoft.EntityFrameworkCore;
using School.Models;

namespace SchoolTest.Serves
{

    public class StudentService : IServies<Student>
    {
        #region Fields
        SchoolContext _context;
        #endregion

        #region Constructor
        public StudentService(SchoolContext _schoolContext)
        {
            _context = _schoolContext;
        }
        #endregion

        #region Methods
        #region GetStudents
        public async Task<List<Student>> GetAll()
        {
            List<Student>? students = await _context.Students
            .Include(s => s.Department)
            .Include(s => s.StudentsCourses
            .OrderByDescending(sc => sc.Grade))
            .ToListAsync();

            return students;
        }
        #endregion

        #region Student Details
        public async Task<Student> Details(int id)
        {

            Student? student = await _context.Students
                .Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.ID == id);

            return student;
        }
        #endregion

        #region Create
        public async Task<Student> Create(Student student)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }
        #endregion

        #region Find
        public async Task<Student> Find(int? id)
        {
            return await _context.Students.FindAsync(id);
        }
        #endregion

        #region Edit
        public async Task<Student> Edit(Student student)
        {
            _context.Update(student);
            await _context.SaveChangesAsync();

            return student;
        }
        #endregion

        #region Delete
        public async Task<Student> Delete(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(m => m.ID == id);
        }

        public async void DeleteConfirmed(Student student)
        {
            if (student != null)
            {
                _context.Students.Remove(student);
            }
            await _context.SaveChangesAsync();
        }
        #endregion

        public bool EntityExists(int id)
        {
            return (_context.Students?.Any(e => e.ID == id)).GetValueOrDefault();
        }
        #endregion
    }
}
