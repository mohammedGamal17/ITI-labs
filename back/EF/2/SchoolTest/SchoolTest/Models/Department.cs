using SchoolTest.Models;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Department : IComparable<Department>, IComparer<Department>
    {
        #region Prop
        public int ID { get; set; }

        [Required, StringLength(maximumLength: 20, MinimumLength = 2)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<Student>? Students { get; set; } = new HashSet<Student>();

        public virtual ICollection<DepartmentsCourses> DepartmentsCousrces { get; set; } = new HashSet<DepartmentsCourses>();

        #endregion

        #region Methods
        int IComparer<Department>.Compare(Department? x, Department? y)
        {

            int result = x!.Name!.CompareTo(y!.Name);
            if (result != 0) return result;

            result = x.Description.CompareTo(y.Description);
            if (result != 0) return result;


            return x.ID.CompareTo(y.ID);
        }

        int IComparable<Department>.CompareTo(Department? other)
        {
            if (other == null) return -100;


            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Department other = (Department)obj;
            return ID == other.ID && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name!.GetHashCode();
        }

        public override string ToString()
        {
            return $"Department {{ ID = {this.ID}, Name = {this.Name}, Description = {this.Description} }}";
        }
        #endregion

    }
}
