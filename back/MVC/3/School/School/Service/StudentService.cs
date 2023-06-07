using School.Models;

namespace School.Service
{
    public class StudentService
    {

        static Students students = new Students()
        {
            new Student {Id=1,Name="Mohammed",Age=25,Email="mohammed_gamal7@outlook.com",DepertmentID=4},
            new Student {Id=2,Name="AboBakr",Age=19,Email="abobakr_gamal@outlook.com",DepertmentID=2},
            new Student {Id=3,Name="Gamal",Age=58,Email="gamal_mahmoud@outlook.com",DepertmentID=4},
            new Student {Id=4,Name="Hassan",Age=55,Email="hassan_mahmoud@outlook.com",DepertmentID=1},
            new Student {Id=5,Name="Mahmoud",Age=80,Email="mahmoud_ahmed@outlook.com",DepertmentID=3},
        };
        public Students getAllStudents()
        {
            return students;
        }


        // get
        public Student? GetStudentDetails(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            return student == null ? null : student;
        }
        // create
        public Students InsertStudent(Student student)
        {
            if (student.Id == 0)
                student.Id = students.Count + 1;

            students.Add(student);
            return students;
        }
        // update

        public Student UpdateStudent(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
        // delete
        public Students DeleteDepartment(int id)
        {
            students.RemoveAll(s => s.Id == id);
            return students;
        }
    }
}
