using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolTest.Models;
using SchoolTest.Serves;

namespace SchoolTest.Controllers
{
    public class CoursesController : Controller
    {
        #region Fields
        IServies<Course> _context;
        #endregion

        #region Constructor
        public CoursesController(IServies<Course> _courseContext)
        {
            _context = _courseContext;
        }
        #endregion

        #region Methods

        #region Get All Courses
        public async Task<IActionResult> Index()
        {
            List<Course>? courses = await _context.GetAll();
            if (courses == null) return BadRequest("No Courses Found");

            return View(courses);
        }

        #endregion

        #region Get Course Detail
        public async Task<IActionResult> Details(int id)
        {
            if (id == null) return NotFound("Invalid ID");

            Course? course = await _context.Details(id);

            if (course == null) return NotFound("No Student Founded");

            return View(course);
        }

        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Duration")] Course course)
        {
            if (ModelState.IsValid)
            {
                await _context.Create(course);

                return RedirectToAction("Index");
            }
            return View(course);
        }

        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound("Invalid ID");

            Course? course = await _context.Find(id);

            if (course == null) return NotFound("No Department Founded");

            return View(course);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Duration")] Course course)
        {
            if (id != course.ID) return NotFound("Invalid ID");

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Edit(course);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.EntityExists(course.ID)) return NotFound("No Department Founded");
                }

                return RedirectToAction("Index");
            }
            return View(course);
        }

        #endregion

        #endregion


        #region Delete
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return NotFound("Invalid ID");

            Course? course = await _context.Delete(id);

            if (course == null) return NotFound("No Department Founded");

            return View(course);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            Course? course = await _context.Find(id);

            _context.DeleteConfirmed(course);

            return RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
