using System.ComponentModel.DataAnnotations;

namespace SchoolTest.Models
{
    public class Course : IComparable<Course>, IComparer<Course>
    {
        #region Prop
        public int ID { get; set; }

        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(maximumLength: int.MaxValue, MinimumLength = 5)]
        public string Description { get; set; }

        [Range(5, 40)]
        public int Duration { get; set; }

        public virtual ICollection<DepartmentsCourses> DepartmentsCousrces { get; set; } = new HashSet<DepartmentsCourses>();

        #endregion

        #region Methods
        int IComparer<Course>.Compare(Course? x, Course? y)
        {
            int result = x!.Name!.CompareTo(y!.Name);
            if (result != 0) return result;

            result = x.Description.CompareTo(y.Description);
            if (result != 0) return result;

            result = x.Duration.CompareTo(y.Duration);
            if (result != 0) return result;


            return x.ID.CompareTo(y.ID);
        }

        int IComparable<Course>.CompareTo(Course? other)
        {
            if (other == null) return -100;


            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Course other = (Course)obj;
            return ID == other.ID && Name == other.Name && Duration == other.Duration;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name!.GetHashCode() ^ Duration!.GetHashCode();

        }

        public override string ToString()
        {
            return $"Department {{ ID = {ID}, Name = {Name}, Description = {Description}, Duration = {Duration} }}";
        }
        #endregion
    }
}
