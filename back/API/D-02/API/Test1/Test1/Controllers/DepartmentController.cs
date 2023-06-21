using Microsoft.AspNetCore.Mvc;
using Test1.DTO.Department;
using Test1.Models;
using Test1.Service;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        #region Fileds
        IRepository<Department> _repository;
        #endregion

        #region Constructors
        public DepartmentController(IRepository<Department> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods

        #region Get 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            IEnumerable<Department> depts = await _repository.GetAllAsync();
            if (depts == null) return BadRequest();

            return Ok(depts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            Department department = await _repository.GetByIdAsync(id);

            if (department == null) return NotFound();

            DepartmentDto departmentDto = new DepartmentDto()
            {
                ID = department.ID,
                Name = department.Name,
                Description = department.Description,

                Students = department.Students,
            };

            return Ok(departmentDto);
        }

        #endregion

        #region Add
        [HttpPost]
        public async Task<ActionResult> AddDepartment(Department department)
        {
            if (department == null) return BadRequest();
            try
            {
                await _repository.AddAsync(department);
                return CreatedAtAction("GetDepartmentById", new { id = department.ID }, department);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        #endregion

        #region Update
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDepartment([FromForm] Department department, int id)
        {
            if (department == null) return NotFound();
            if (id != department.ID) return BadRequest();

            try
            {
                await _repository.UpdateAsync(department, id);
                return NoContent();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }
        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            Department department = await _repository.GetByIdAsync(id);
            if (department == null) return NotFound();
            try
            {
                await _repository.DeleteAsync(id);
                return Ok(department);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        #endregion

        #endregion
    }
}
