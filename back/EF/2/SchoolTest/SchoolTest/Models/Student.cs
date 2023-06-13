using SchoolTest.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Student : IComparable<Student>, IComparer<Student>
    {
        #region Prop
        public int ID { get; set; }

        [StringLength(maximumLength: 10, MinimumLength = 3)]
        public string? Name { get; set; }

        [Range(minimum: 20, maximum: 30)]
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [ForeignKey(name: "Department")]
        public int DeptID { get; set; }

        public Department? Department { get; set; }

        public ICollection<StudentsCourses> StudentsCourses { get; set; } = new HashSet<StudentsCourses>();
        #endregion

        #region Methods
        public int Compare(Student? x, Student? y)
        {
            int result = x!.Name!.CompareTo(y!.Name);
            if (result != 0) return result;

            result = x.Age.CompareTo(y.Age);
            if (result != 0) return result;

            result = x!.Email!.CompareTo(y.Email);
            if (result != 0) return result;

            result = x!.DeptID!.CompareTo(y!.DeptID);
            if (result != 0) return result;

            return x.ID.CompareTo(y.ID);
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return -100;


            return Name.CompareTo(other.Name);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Student other = (Student)obj;
            return ID == other.ID && Name == other.Name && Age == other.Age && Email == other.Email && DeptID == other.DeptID;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name!.GetHashCode() ^ Age.GetHashCode() ^ Email!.GetHashCode() ^ DeptID.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Email: {Email}, Department ID: {DeptID}";
        }
        #endregion

    }
}
