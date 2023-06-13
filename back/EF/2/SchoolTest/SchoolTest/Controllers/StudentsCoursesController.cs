using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Models;
using SchoolTest.Models;

namespace SchoolTest.Controllers
{
    public class StudentsCoursesController : Controller
    {
        #region Fields
        SchoolContext _context;
        #endregion

        #region Constructor
        public StudentsCoursesController(SchoolContext _schoolContext)
        {
            _context = _schoolContext;
        }
        #endregion

        #region Index
        [Route("StudentsCourses/Index")]
        public async Task<IActionResult> Index()
        {
            var schoolContext = _context.StudentsCourses
                .Include(s => s.Course)
                .OrderBy(o => o.Course.Name)
                .Include(s => s.Student);
            return View(await schoolContext.ToListAsync());
        }

        #endregion

        #region Details
        [Route("Details/{CursID}/{StdId}")]
        public async Task<IActionResult> Details(int? CursID, int? StdId)
        {
            if (CursID == null || StdId == null || _context.StudentsCourses == null)
            {
                return NotFound();
            }

            var studentsCourses = await _context.StudentsCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StdId == StdId && m.CursID == CursID);
            if (studentsCourses == null)
            {
                return NotFound();
            }

            return View(studentsCourses);
        }
        #endregion

        #region MyRegion

        [Route("StudentsCourses/Create")]

        public IActionResult Create()
        {
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description");
            ViewData["StdId"] = new SelectList(_context.Students, "ID", "Email");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("StudentsCourses/Create")]

        public async Task<IActionResult> Create([Bind("StdId,CursID,Grade")] StudentsCourses studentsCourses)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(studentsCourses);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return BadRequest("This student has already grade");
                }

            }
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", studentsCourses.CursID);
            ViewData["StdId"] = new SelectList(_context.Students, "ID", "Email", studentsCourses.StdId);
            return View(studentsCourses);
        }

        #endregion

        #region Edit
        [Route("Edit/{CursID}/{StdId}")]
        public async Task<IActionResult> Edit(int? StdId, int? CursID)
        {
            if (StdId == null || CursID == null || _context.StudentsCourses == null)
            {
                return NotFound();
            }

            StudentsCourses? studentsCourses = await _context.StudentsCourses.FindAsync(StdId, CursID);
            if (studentsCourses == null)
            {
                return NotFound();
            }
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", studentsCourses.CursID);
            ViewData["StdId"] = new SelectList(_context.Students, "ID", "Email", studentsCourses.StdId);
            return View(studentsCourses);
        }

        [Route("Edit/{CursID}/{StdId}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? StdId, int? CursID, [Bind("StdId,CursID,Grade")] StudentsCourses studentsCourses)
        {
            ViewBag.studentId = StdId;
            ViewBag.courseId = CursID;

            if (StdId != studentsCourses.StdId && CursID != studentsCourses.CursID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentsCourses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsCoursesExists(studentsCourses.StdId))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", studentsCourses.CursID);
            ViewData["StdId"] = new SelectList(_context.Students, "ID", "Email", studentsCourses.StdId);
            return View(studentsCourses);
        }
        #endregion

        #region Delete
        [Route("Delete/{CursID}/{StdId}")]
        public async Task<IActionResult> Delete(int? StdId, int? CursID)
        {
            ViewBag.studentId = StdId;
            ViewBag.courseId = CursID;

            if (StdId == null || CursID == null || _context.StudentsCourses == null)
            {
                return NotFound();
            }


            var studentsCourses = await _context.StudentsCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StdId == StdId && m.CursID == CursID);
            if (studentsCourses == null)
            {
                return NotFound();
            }

            return View(studentsCourses);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Delete/{CursID}/{StdId}")]
        public async Task<IActionResult> DeleteConfirmed(int? StdId, int? CursID)
        {
            if (_context.StudentsCourses == null)
            {
                return Problem("Entity set 'SchoolContext.StudentsCourses'  is null.");
            }
            var studentsCourses = await _context.StudentsCourses.FirstOrDefaultAsync(s => s.CursID == CursID && s.StdId == StdId);
            if (studentsCourses != null)
            {
                _context.StudentsCourses.Remove(studentsCourses);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        private bool StudentsCoursesExists(int id)
        {
            return (_context.StudentsCourses?.Any(e => e.StdId == id)).GetValueOrDefault();
        }
    }
}
