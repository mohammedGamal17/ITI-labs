using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        static Students students = new Students() {
            new Student {Id=1,Name="Mohammed",Age=25,Email="mohammed_gamal7@outlook.com"},
            new Student {Id=2,Name="AboBakr",Age=19,Email="abobakr_gamal@outlook.com"},
            new Student {Id=3,Name="Gamal",Age=58,Email="gamal_mahmoud@outlook.com"},
            new Student {Id=4,Name="Hassan",Age=55,Email="hassan_mahmoud@outlook.com"},
            new Student {Id=5,Name="Mahmoud",Age=80,Email="mahmoud_ahmed@outlook.com"},
        };

        public ViewResult DisplayStudents()
        {
            return View(students);
        }

        public ViewResult StudentDetails(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            return View(student);
        }

        public ViewResult AddStudent()
        {
            return View();
        }

        public RedirectToActionResult InsertStudent(Student student)
        {
            student.Id = students.Count + 1;

            students.Add(student);

            return RedirectToAction("DisplayStudents");
        }

        public ViewResult UpdateStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            return View(student);
        }
        public RedirectToActionResult Update(int id, Student student)
        {
            Student updatedStudent = students.FirstOrDefault(s => s.Id == id);

            updatedStudent.Id = id;
            updatedStudent.Age = student.Age;
            updatedStudent.Email = student.Email;
            updatedStudent.Name = student.Name;


            return RedirectToAction("DisplayStudents");
        }

        public RedirectToActionResult DeleteStudent(int id)
        {
            students.RemoveAll(s => s.Id == id);

            return RedirectToAction("DisplayStudents");
        }
    }
}
