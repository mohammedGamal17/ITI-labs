using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Student : IComparable<Student>, IComparer<Student>
    {

        public int Id { get; set; }

        [Required, StringLength(maximumLength: 10, MinimumLength = 3)]
        public string Name { get; set; }

        [Required, Range(minimum: 20, maximum: 30)]
        public int Age { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int DepertmentID { get; set; }

        public int Compare(Student? x, Student? y)
        {
            int result = x!.Name!.CompareTo(y!.Name);
            if (result != 0) return result;

            result = x.Age.CompareTo(y.Age);
            if (result != 0) return result;

            result = x!.Email!.CompareTo(y.Email);
            if (result != 0) return result;


            return x.Id.CompareTo(y.Id);
        }

        public int CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            Student other = (Student)obj;
            return Id == other.Id && Name == other.Name && Age == other.Age && Email == other.Email;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name!.GetHashCode() ^ Age.GetHashCode() ^ Email!.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Email: {Email}";
        }
    }
}
