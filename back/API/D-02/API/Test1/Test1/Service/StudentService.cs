using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Service
{
    public class StudentService : IRepository<Student>
    {
        #region Fields
        SchoolContext _context;
        #endregion

        #region Constructor
        public StudentService(SchoolContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods

        #region Get
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context
                .Students
                .Include(s => s.InverseStudentSuperNavigation)
                .Include(s => s.StudentSuperNavigation)
                .Include(s => s.Dept)
                .Include(s => s.StudentsCourses)
                .ThenInclude(sc => sc.Curs)
                .ToListAsync();
        }

        public Task<Student> GetByIdAsync(int id)
        {
            return _context.Students
                .Include(s => s.InverseStudentSuperNavigation)
                .Include(s => s.StudentSuperNavigation)
                .Include(s => s.Dept)
                .Include(s => s.StudentsCourses)
                .ThenInclude(sc => sc.Curs)
                .FirstOrDefaultAsync(s => s.ID == id);
        }
        #endregion

        #region Add
        public async Task AddAsync(Student entity)
        {
            await _context.Students.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Update
        public async Task UpdateAsync(Student entity, int id)
        {
            _context.Entry<Student>(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task DeleteAsync(int id)
        {
            if (await IsExisted(id) != null)
            {
                _context.Students.Remove(await IsExisted(id));
                await _context.SaveChangesAsync();
            }
        }
        #endregion

        #region IsExisted
        private async Task<Student> IsExisted(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(dep => dep.ID == id);
        }
        #endregion
        #endregion
    }
}
