using DataAccessLayer;
using System.Data;

namespace DataBasinessLayer
{
    public class StudentManager
    {

        public static Students GetDepartmentStudent(int _departmentID)
        {
            string query = $"select * from Student where Department_ID={_departmentID};";

            DataTable dataTable = DBManager.ExecuteSelectedDisconnect(query);

            return ConvertFromDataTableToDepartmentList(dataTable);
        }

        public static int InsertStudent(Student _student)
        {
            string query = $"INSERT INTO Student (Name,Age,Department_ID) VALUES('{_student.Name}',{_student.Age} ,{_student.DepartmentID});";

            return DBManager.ExecuteNonQuery(query);
        }

        private static Students ConvertFromDataTableToDepartmentList(DataTable dt)
        {
            Students students = new Students();

            foreach (DataRow dataRow in dt.Rows)
            {
                students.Add(ConvertFromDataRowToDepartment(dataRow));
            }

            return students;
        }
        private static Student ConvertFromDataRowToDepartment(DataRow row)
        {
            Student student = new Student();

            #region Mapping
            if (int.TryParse(row["ID"].ToString(), out int id)) { student.ID = id; }

            student.Name = row["Name"].ToString();
            #endregion


            return student;
        }


    }
}
