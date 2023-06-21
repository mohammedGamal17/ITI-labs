using Microsoft.AspNetCore.Mvc;
using Test1.Models;
using Test1.Service;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        IRepository<Student> _repository;
        #endregion
        #region Constructors
        public StudentController(IRepository<Student> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods

        #region Get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {
            //IEnumerable<Student> students = await _repository.GetAllAsync();
            //if (students == null) return BadRequest();

            //List<StudentDto> studentsDto = new List<StudentDto>();

            //foreach (var std in students)
            //{
            //    StudentDto studentDto = new StudentDto()
            //    {
            //        Id = std.ID,
            //        Name = std.Name,
            //        Email = std.Email,
            //        DepartmentName = std.Dept.Name,
            //        //StudentsCourses = std.StudentsCourses,
            //        StudentSuperName = std.StudentSuperNavigation.Name
            //    };
            //    studentsDto.Add(studentDto);
            //}


            //return Ok(studentsDto);



            IEnumerable<Student> students = await _repository.GetAllAsync();
            List<StudentDto> studentsDto = new List<StudentDto>();

            if (students == null)
            {
                return NotFound();
            }

            foreach (Student std in students)
            {
                StudentDto studentDto = new StudentDto()
                {
                    Id = std.ID,
                    Name = std.Name,
                    Email = std.Email,
                    DepartmentName = std.Dept.Name,
                    //StudentsCourses = std.StudentsCourses,
                    StudentSuperName = std?.StudentSuperNavigation?.Name
                };
                studentsDto.Add(studentDto);
            }

            return Ok(studentsDto);


        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            Student student = await _repository.GetByIdAsync(id);
            if (student == null) return BadRequest();

            StudentDto studentDto = new StudentDto()
            {
                Id = student.ID,
                Name = student.Name,
                Email = student.Email,
                DepartmentName = student.Dept.Name,
                //StudentsCourses = student.StudentsCourses,
                StudentSuperName = student?.StudentSuperNavigation?.Name

            };
            return Ok(studentDto);

        }

        #endregion

        #region Add

        #endregion

        #region update

        #endregion

        #region Delete

        #endregion

        #endregion
    }
}
