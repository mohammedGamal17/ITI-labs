using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Models;
using SchoolTest.Models;

namespace SchoolTest.Controllers
{
    public class DepartmentsCoursesController : Controller
    {
        #region Fields
        SchoolContext _context;
        #endregion

        #region Constructor
        public DepartmentsCoursesController(SchoolContext _schoolContext)
        {
            _context = _schoolContext;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            var schoolContext = _context.DepartmentsCourses.Include(d => d.Course).Include(d => d.Department);
            return View(await schoolContext.ToListAsync());
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DepartmentsCourses == null)
            {
                return NotFound();
            }

            var departmentsCourses = await _context.DepartmentsCourses
                .Include(d => d.Course)
                .Include(d => d.Department)
                .FirstOrDefaultAsync(m => m.DeptID == id);
            if (departmentsCourses == null)
            {
                return NotFound();
            }

            return View(departmentsCourses);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description");
            ViewData["DeptID"] = new SelectList(_context.Departments, "ID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeptID,CursID")] DepartmentsCourses departmentsCourses)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(departmentsCourses);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                catch (Exception ex)
                {
                    return BadRequest("This Department has already This Course");
                }
            }
            ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", departmentsCourses.CursID);
            ViewData["DeptID"] = new SelectList(_context.Departments, "ID", "Name", departmentsCourses.DeptID);
            return View(departmentsCourses);
        }
        #endregion

        #region Edit
        //public async Task<IActionResult> Edit(string? id)
        //{
        //    if (id == null || _context.DepartmentsCourses == null)
        //    {
        //        return NotFound();
        //    }
        //    var keyValues = id.ToString().Split(',');
        //    int courseId = int.Parse(keyValues[0]);
        //    int departmentId = int.Parse(keyValues[1]);

        //    //var departmentsCourses = await _context.DepartmentsCourses.FindAsync(courseId, departmentId);
        //    DepartmentsCourses? departmentsCourses = _context.DepartmentsCourses.Find(courseId, departmentId);
        //    if (departmentsCourses == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", departmentsCourses.CursID);
        //    ViewData["DeptID"] = new SelectList(_context.Departments, "ID", "Name", departmentsCourses.DeptID);
        //    return View(departmentsCourses);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit([Bind("DeptID,CursID")] DepartmentsCourses departmentsCourses)
        //{
        //    //if (id != departmentsCourses.DeptID)
        //    //{
        //    //    return NotFound();
        //    //}

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(departmentsCourses);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!DepartmentsCoursesExists(departmentsCourses.DeptID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CursID"] = new SelectList(_context.Courses, "ID", "Description", departmentsCourses.CursID);
        //    ViewData["DeptID"] = new SelectList(_context.Departments, "ID", "Name", departmentsCourses.DeptID);
        //    return View(departmentsCourses);
        //}

        #endregion

        #region Delete
        public async Task<IActionResult> Delete(string? id)
        {

            var keyValues = id.ToString().Split(',');
            int courseId = int.Parse(keyValues[0]);
            int departmentId = int.Parse(keyValues[1]);
            if (_context.DepartmentsCourses == null)
            {
                return Problem("Entity set 'SchoolContext.DepartmentsCourses'  is null.");
            }


            if (id == null || _context.DepartmentsCourses == null) return NotFound();


            DepartmentsCourses? departmentsCourses = await _context.DepartmentsCourses
                .Include(d => d.Course)
                .Include(d => d.Department)
                .FirstOrDefaultAsync(m => m.DeptID == departmentId && m.CursID == courseId);

            if (departmentsCourses == null) return NotFound();


            return View(departmentsCourses);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var keyValues = id.ToString().Split(',');
            int courseId = int.Parse(keyValues[0]);
            int departmentId = int.Parse(keyValues[1]);
            if (_context.DepartmentsCourses == null)
            {
                return Problem("Entity set 'SchoolContext.DepartmentsCourses'  is null.");
            }


            DepartmentsCourses? departmentsCourses = await _context.DepartmentsCourses
                .Include(d => d.Course)
                .Include(d => d.Department)
                .FirstOrDefaultAsync(m => m.DeptID == departmentId && m.CursID == courseId);


            if (departmentsCourses != null)
            {
                _context.DepartmentsCourses.Remove(departmentsCourses);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion

        private bool DepartmentsCoursesExists(int id)
        {
            return (_context.DepartmentsCourses?.Any(e => e.DeptID == id)).GetValueOrDefault();
        }
    }
}
