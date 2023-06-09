using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Service;

namespace School.Controllers
{
    public class DepartmentController : Controller
    {
        static SchoolContext context = new SchoolContext();

        public IActionResult Index()
        {

            DepartmentService departmentService = new DepartmentService();

            return View(context.Departments.ToList());
        }
        public IActionResult DepartmentDetails(int id)
        {
            DepartmentService departmentService = new DepartmentService();

            Department? department = context.Departments.FirstOrDefault(d => d.ID == id);
            if (department == null) return BadRequest();

            return View(department);
        }


        public IActionResult InsertDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertDepartment(Department department)
        {
            if (!ModelState.IsValid) return BadRequest();


            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteDepartment(int id)
        {
            Department? department = context.Departments.FirstOrDefault(d => d.ID == id);
            if (department == null) return BadRequest();

            context.Departments.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult EditDepartment(int? id)
        {
            if (id == null || context.Departments == null)
            {
                return NotFound();
            }

            Department? department = context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        [HttpPost]
        public IActionResult EditDepartment(int id, [Bind("ID,Name,Description")] Department department)
        {
            if (id != department.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var existingDepartment = context.Departments.Local.FirstOrDefault(d => d.ID == department.ID);
                if (existingDepartment != null)
                {
                    existingDepartment.Name = department.Name;
                    existingDepartment.Description = department.Description;
                }
                else
                {
                    context.Departments.Attach(department);
                    context.Entry(department).State = EntityState.Modified;
                }

                return RedirectToAction("Index");
            }
            return View(department);
        }


    }


}
