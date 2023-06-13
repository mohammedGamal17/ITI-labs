using Microsoft.EntityFrameworkCore;
using School.Models;
using SchoolTest.Models;

namespace SchoolTest.Serves
{
    public class CourseService : IServies<Course>
    {

        #region Fields
        SchoolContext _context;

        #endregion

        #region Constructors
        public CourseService(SchoolContext schoolContext)
        {
            _context = schoolContext;
        }
        #endregion

        #region Methods

        #region Get All
        public async Task<List<Course>> GetAll()
        {
            List<Course>? course = await _context.Courses.ToListAsync();
            return course;
        }
        #endregion

        #region Get Course
        public async Task<Course> Details(int id)
        {
            Course? course = await _context.Courses
                .FirstOrDefaultAsync(m => m.ID == id);

            return course;
        }
        #endregion

        #region Create
        public async Task<Course> Create(Course course)
        {
            _context.Add(course);
            await _context.SaveChangesAsync();

            return course;
        }

        #endregion

        #region Find
        public async Task<Course> Find(int? id)
        {
            return await _context.Courses.FindAsync(id);

        }

        #endregion

        #region Edit
        public async Task<Course> Edit(Course course)
        {
            _context.Update(course);
            await _context.SaveChangesAsync();

            return course;
        }
        #endregion

        #region Delete
        public async Task<Course> Delete(int id)
        {
            return await _context.Courses.FirstOrDefaultAsync(m => m.ID == id);

        }

        public async void DeleteConfirmed(Course course)
        {
            if (course != null) _context.Courses.Remove(course);

            await _context.SaveChangesAsync();
        }
        #endregion

        public bool EntityExists(int id)
        {
            return (_context.Courses?.Any(e => e.ID == id)).GetValueOrDefault();

        }
        #endregion


    }
}
