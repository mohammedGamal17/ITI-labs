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
        public Task<IEnumerable<Student>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Add
        public Task AddAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Update
        public Task UpdateAsync(Student entity, int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #endregion
    }
}
