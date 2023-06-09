using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Models;
using School.Service;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        static SchoolContext context = new SchoolContext();
        public IActionResult Index()
        {

            //StudentService studentService = new StudentService();

            return View(context.Students.ToList());
        }

        public IActionResult StudentDetails(int id)
        {
            Student? student = context.Students.FirstOrDefault(s => s.ID == id);
            if (student == null) return BadRequest();

            return View(student);
        }

        public IActionResult AddStudent()
        {

            //DepartmentService departmentService = new DepartmentService();
            List<Department>? departments = context.Departments.ToList();
            if (departments == null) return BadRequest();

            ViewBag.Departments = new SelectList(departments, "ID", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            Department? department = context.Departments.FirstOrDefault(s => s.ID == student.Department.ID);
            if (department == null) return BadRequest();
            student.Department = department;
            if (ModelState.IsValid)
            {


                context.Students.Add(student);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            List<Department>? departments = context.Departments.ToList();
            ViewBag.Departments = new SelectList(departments, "ID", "Name");
            return View();

        }

        public IActionResult UpdateStudent(Student student)

        {
            StudentService studentService = new StudentService();
            Student std = studentService.GetStudentDetails(student.ID);
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
        //    Student? student = students.FirstOrDefault(s => s.ID == id);
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

        //    Student? updatedStudent = students.FirstOrDefault(s => s.ID == id);
        //    if (student == null)
        //        return BadRequest();


        //    updatedStudent.ID = id;
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
