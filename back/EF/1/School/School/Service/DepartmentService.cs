using School.Models;

namespace School.Service
{
    public class DepartmentService
    {
        static List<Department> departments = new List<Department>()
        {
            new Department(){ID=1,Name="SE",Description="Software Engineering"},
            new Department(){ID=2,Name="CS",Description="Computer Scince"},
            new Department(){ID=3,Name=".NET",Description="Full Stack .NET "},
            new Department(){ID=4,Name="Python",Description="Python"}
        };


        // Get All
        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        // Get Dept by ID
        public Department GetDepartmentByID(int id)
        {

            Department? dept = departments.FirstOrDefault(d => d.ID == id);

            return dept == null ? null : dept;
        }

        //add
        public List<Department> Add(Department department)
        {
            if (department.ID == 0)
                department.ID = departments.Count + 1;
            departments.Add(department);
            return departments;
        }

        public List<Department> DeleteDepartment(int id)
        {
            departments.RemoveAll(s => s.ID == id);
            return departments;
        }
    }
}
