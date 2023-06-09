using School.Models;

namespace School.Service
{
    public class StudentService
    {

        static List<Student> students = new List<Student>()
        {
            new Student {ID=1,Name="Mohammed",Age=25,Email="mohammed_gamal7@outlook.com"},
            new Student {ID=2,Name="AboBakr",Age=19,Email="abobakr_gamal@outlook.com"},
            new Student {ID=3,Name="Gamal",Age=58,Email="gamal_mahmoud@outlook.com"},
            new Student {ID=4,Name="Hassan",Age=55,Email="hassan_mahmoud@outlook.com"},
            new Student {ID=5,Name="Mahmoud",Age=80,Email="mahmoud_ahmed@outlook.com"},

        };
        public List<Student> getAllStudents()
        {
            return students;
        }


        // get
        public Student? GetStudentDetails(int id)
        {
            Student? student = students.FirstOrDefault(s => s.ID == id);

            return student == null ? null : student;
        }
        // create
        public List<Student> InsertStudent(Student student)
        {
            if (student.ID == 0)
                student.ID = students.Count + 1;

            students.Add(student);
            return students;
        }
        // update

        public Student UpdateStudent(int id)
        {
            return students.FirstOrDefault(s => s.ID == id);
        }
        // delete
        public List<Student> DeleteDepartment(int id)
        {
            students.RemoveAll(s => s.ID == id);
            return students;
        }
    }
}
