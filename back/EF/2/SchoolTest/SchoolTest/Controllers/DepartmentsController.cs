using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using SchoolTest.Serves;

namespace SchoolTest.Controllers
{
    public class DepartmentsController : Controller
    {

        IServies<Department> _context;

        #region Constructoe
        public DepartmentsController(IServies<Department> _service)
        {
            _context = _service;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Department>? departments = await _context.GetAll();

            if (departments == null) return NotFound();

            return View(departments);

        }

        #endregion

        #region Details
        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound("Invalid ID");


            Department? department = await _context.Details(id);

            if (department == null) return NotFound("No Department Founded");


            return View(department);
        }

        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] Department department)
        {
            if (ModelState.IsValid)
            {
                await _context.Create(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound("Invalid ID");


            Department? department = await _context.Find(id);

            if (department == null) return NotFound("No Department Founded");

            return View(department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description")] Department department)
        {
            if (id != department.ID) return NotFound("Invalid ID");

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Edit(department);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.EntityExists(department.ID)) return NotFound("No Department Founded");
                }

                return RedirectToAction("Index");
            }
            return View(department);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return NotFound("Invalid ID");

            Department? department = await _context.Delete(id);

            if (department == null) return NotFound("No Department Founded");

            return View(department);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            Department? department = await _context.Find(id);

            _context.DeleteConfirmed(department);

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
