using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Service
{
    public class DepartmentService : IRepository<Department>
    {
        #region Fileds
        SchoolContext _context;
        #endregion

        #region Constructor
        public DepartmentService(SchoolContext schoolContext)
        {
            _context = schoolContext;
        }
        #endregion

        #region Methods

        #region Get 
        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return await _context.Departments
                  .Include(d => d.Students)
                  .Include(d => d.Curs)
                  .ToListAsync();
        }

        public async Task<Department> GetByIdAsync(int id)
        {

            return await _context.Departments
                .Include(d => d.Students)
                .Include(d => d.Curs)
                .FirstOrDefaultAsync(d => d.ID == id);
        }

        #endregion

        #region Add
        public async Task AddAsync(Department entity)
        {
            await _context.Departments.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Update
        public async Task UpdateAsync(Department entity, int id)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task DeleteAsync(int id)
        {
            Department department = await GetDepartment(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
            }
        }

        private async Task<Department> GetDepartment(int id)
        {
            return await _context.Departments.FirstOrDefaultAsync(dep => dep.ID == id);
        }
        #endregion

        #endregion

    }
}
