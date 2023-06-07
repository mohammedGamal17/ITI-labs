using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Models;
using School.Service;

namespace School.Controllers
{
    public class StudentController : Controller
    {



        public IActionResult Index()
        {
            StudentService studentService = new StudentService();
            return View(studentService.getAllStudents());
        }

        public IActionResult StudentDetails(int id)
        {
            if (id == null || id == 0)
                return BadRequest("FUCK YOU");
            StudentService studentService = new StudentService();
            Student? student = studentService.GetStudentDetails(id);
            if (studentService.GetStudentDetails(id) == null) return BadRequest();

            return View(student);
        }

        public IActionResult AddStudent()
        {
            DepartmentService departmentService = new DepartmentService();

            SelectList selectListItems = new SelectList(departmentService.GetAllDepartments(), dataValueField: "Id", dataTextField: "Name");
            ViewBag.Items = selectListItems;
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentService studentService = new StudentService();
                studentService.InsertStudent(student);

                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult UpdateStudent(Student student)

        {
            StudentService studentService = new StudentService();
            Student std = studentService.GetStudentDetails(student.Id);
            return View(std);
        }

        [HttpPost]
        public IActionResult UpdateStudentForm(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (student == null)
                return BadRequest();

            student.Name = student.Name;
            student.Age = student.Age;
            student.Email = student.Email;

            return RedirectToAction("Index");
        }


        //public IActionResult UpdateStudent(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    Student? student = students.FirstOrDefault(s => s.Id == id);
        //    if (student == null)
        //        return BadRequest();
        //    return View(student);
        //}

        //[HttpPost]
        //public IActionResult UpdateStudent(int id, Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    Student? updatedStudent = students.FirstOrDefault(s => s.Id == id);
        //    if (student == null)
        //        return BadRequest();


        //    updatedStudent.Id = id;
        //    updatedStudent.Age = student.Age;
        //    updatedStudent.Email = student.Email;
        //    updatedStudent.Name = student.Name;


        //    return RedirectToAction("Index");
        //}

        public IActionResult DeleteStudent(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            StudentService studentService = new StudentService();
            studentService.DeleteDepartment(id);


            return RedirectToAction("Index");
        }
    }
}
