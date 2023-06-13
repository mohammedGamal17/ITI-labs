using Microsoft.EntityFrameworkCore;
using School.Models;
namespace SchoolTest.Serves
{

    public class DepartmentService : IServies<Department>
    {
        #region Fields
        SchoolContext _context;
        #endregion

        #region Constructor
        public DepartmentService(SchoolContext _schoolContext)
        {
            _context = _schoolContext;
        }
        #endregion

        #region Methods       
        #region GetDepartments
        public async Task<List<Department>> GetAll()
        {
            List<Department>? departments = await _context.Departments.ToListAsync();

            return departments;
        }
        #endregion

        #region Details
        public async Task<Department> Details(int id)
        {
            Department? department = await _context.Departments
                .FirstOrDefaultAsync(m => m.ID == id);

            return department;
        }
        #endregion

        #region Create
        public async Task<Department> Create(Department department)
        {
            _context.Add(department);
            await _context.SaveChangesAsync();

            return department;
        }
        #endregion

        #region Find
        public async Task<Department> Find(int? id)
        {
            return await _context.Departments.FindAsync(id);
        }
        #endregion

        #region Edit
        public async Task<Department> Edit(Department department)
        {
            _context.Update(department);
            await _context.SaveChangesAsync();

            return department;
        }
        #endregion

        #region Delete
        public async Task<Department> Delete(int id)
        {
            return await _context.Departments.FirstOrDefaultAsync(m => m.ID == id);
        }

        public async void DeleteConfirmed(Department department)
        {
            if (department != null) _context.Departments.Remove(department);

            await _context.SaveChangesAsync();
        }
        #endregion

        public bool EntityExists(int id)
        {
            return (_context.Departments?.Any(e => e.ID == id)).GetValueOrDefault();
        }
        #endregion

    }
}
