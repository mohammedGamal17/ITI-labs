namespace School
{
    internal class Department
    {
        public int ID { set; get; }

        public string Name { set; get; }

        List<Student> Students;

        public Department(int _id, string _name)
        {
            ID = _id;
            Name = _name;
            Students = new List<Student>();

        }

        public override string ToString()
        {
            string allStudents = "";

            foreach (var item in Students)
            {
                allStudents += $"\t{item.ToString()}\n";
            }

            return $"ID: {ID},\tName: {Name},\nStudents\n{allStudents}";
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
            s.StudentFired += RemoveStudent;
        }

        void RemoveStudent(Student s)
        {
            Students.Remove(s);
        }
    }
}
