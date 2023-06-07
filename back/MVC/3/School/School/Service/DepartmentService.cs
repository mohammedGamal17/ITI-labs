using School.Models;

namespace School.Service
{
    public class DepartmentService
    {
        static Departments departments = new Departments()
        {
            new Department(){Id=1,Name="SE",Description="Software Engineering"},
            new Department(){Id=2,Name="CS",Description="Computer Scince"},
            new Department(){Id=3,Name=".NET",Description="Full Stack .NET "},
            new Department(){Id=4,Name="Python",Description="Python"}
        };


        // Get All
        public Departments GetAllDepartments()
        {
            return departments;
        }

        // Get Dept by ID
        public Department GetDepartmentByID(int id)
        {

            Department? dept = departments.FirstOrDefault(d => d.Id == id);

            return dept == null ? null : dept;
        }

        //add
        public Departments Add(Department department)
        {
            if (department.Id == 0)
                department.Id = departments.Count + 1;
            departments.Add(department);
            return departments;
        }

        public Departments DeleteDepartment(int id)
        {
            departments.RemoveAll(s => s.Id == id);
            return departments;
        }
    }
}
