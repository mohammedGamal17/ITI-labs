namespace Test1

{
    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string? DepartmentName { get; set; }

        public string? StudentSuperName { get; set; }
        //public IEnumerable<StudentsCourse>? StudentsCourses { get; set; } = new List<StudentsCourse>();

    }
}
