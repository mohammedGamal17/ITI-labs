using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Service;

namespace School.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            DepartmentService departmentService = new DepartmentService();

            return View(departmentService.GetAllDepartments());
        }
        public IActionResult DepartmentDetails(int id)
        {
            DepartmentService departmentService = new DepartmentService();

            return View(departmentService.GetDepartmentByID(id));
        }

        public IActionResult InsertDepartment(Department department)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            DepartmentService departmentService = new DepartmentService();
            departmentService.Add(department);

            return RedirectToAction("Index");
            //return View(departmentService.Add(department));
        }


        public ActionResult DeleteDepartment(int id)
        {
            DepartmentService departmentService = new DepartmentService();
            departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");

        }
        //public ActionResult EditDepartment(Department department) { }


    }
}
