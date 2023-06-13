using School.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolTest.Models
{
    public class DepartmentsCourses
    {
        #region Prop
        [ForeignKey("Department")]
        public int DeptID { get; set; }

        [ForeignKey("Course")]
        public int CursID { get; set; }

        public Department? Department { get; set; }
        public Course? Course { get; set; }
        #endregion
    }
}
