using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Models;
using SchoolTest.Serves;

namespace SchoolTest.Controllers
{
    public class StudentsController : Controller
    {
        IServies<Student> _context;
        IServies<Department> _departmentService;
        public StudentsController(IServies<Student> _service, IServies<Department> _dptService)
        {
            _context = _service;
            _departmentService = _dptService;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Student>? students = await _context.GetAll();

            if (students == null)
            {
                return BadRequest();
            }

            return View(students);
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound("Invalid ID");

            Student? student = await _context.Details(id);

            if (student == null) return NotFound("No Student Founded");

            return View(student);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            ViewData["DeptID"] = new SelectList(await _departmentService.GetAll(), "ID", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Age,Email,DeptID")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _context.Create(student);

                return RedirectToAction("Index");
            }
            ViewData["DeptID"] = new SelectList(await _departmentService.GetAll(), "ID", "Name", student.DeptID);
            return View(student);
        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();


            Student? student = await _context.Find(id);
            if (student == null) return NotFound();

            ViewData["DeptID"] = new SelectList(await _departmentService.GetAll(), "ID", "Name", student.DeptID);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Age,Email,DeptID")] Student student)
        {
            if (id != student.ID) return NotFound();


            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Edit(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.EntityExists(student.ID)) return NotFound();

                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptID"] = new SelectList(await _departmentService.GetAll(), "ID", "Name", student.DeptID);
            return View(student);
        }

        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return NotFound();

            Student? student = await _context.Delete(id);
            if (student == null) return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Student? student = await _context.Find(id);

            _context.DeleteConfirmed(student);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
