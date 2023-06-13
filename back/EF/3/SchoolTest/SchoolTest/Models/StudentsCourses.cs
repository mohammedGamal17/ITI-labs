using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolTest.Models
{
    public class StudentsCourses : IComparable<StudentsCourses>, IComparer<StudentsCourses>
    {
        #region Prop
        [ForeignKey("Student")]
        public int StdId { get; set; }

        [ForeignKey("Course")]
        public int CursID { get; set; }

        [Range(0, 100)]
        public int Grade { get; set; }


        public Student? Student { get; set; }
        public Course? Course { get; set; }

        #endregion

        #region Mwthods

        int IComparer<StudentsCourses>.Compare(StudentsCourses? x, StudentsCourses? y)
        {
            int result = x!.CursID!.CompareTo(y!.CursID);
            if (result != 0) return result;

            result = x.StdId.CompareTo(y.StdId);
            if (result != 0) return result;

            return x.Grade.CompareTo(y.Grade);
        }

        int IComparable<StudentsCourses>.CompareTo(StudentsCourses? other)
        {
            if (other == null) return -100;


            return Grade.CompareTo(other.Grade);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            StudentsCourses other = (StudentsCourses)obj;
            return CursID == other.CursID && StdId == other.StdId && Grade == other.Grade;
        }

        public override int GetHashCode()
        {
            return CursID.GetHashCode() ^ StdId!.GetHashCode() ^ Grade!.GetHashCode();

        }
        public override string ToString()
        {
            return $"Student ID: {StdId}, Course ID: {CursID}, Grade: {Grade}";
        }
        #endregion

    }
}
