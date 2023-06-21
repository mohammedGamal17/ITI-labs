using Test1.Models;

namespace Test1.DTO.Department
{
    public class DepartmentDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Student> StudentsName { get; set; } = new List<Student>();
    }
}
