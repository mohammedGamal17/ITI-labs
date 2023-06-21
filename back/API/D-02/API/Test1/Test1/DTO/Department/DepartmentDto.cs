using Test1.Models;

namespace Test1
{
    public class DepartmentDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        //public string StudentsName { get; set; }

    }
}
