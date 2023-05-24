using DataAccessLayer;
using System.Data;

namespace DataBasinessLayer
{
    public class DepartmentManager
    {
        public static Departments GatAllDepartments()
        {
            string query = "select * from department";
            DataTable dt = DBManager.ExecuteSelectedDisconnect(query);

            return ConvertFromDataTableToDepartmentList(dt);
        }

        private static Departments ConvertFromDataTableToDepartmentList(DataTable dt)
        {
            Departments departments = new Departments();

            foreach (DataRow dataRow in dt.Rows)
            {
                departments.Add(ConvertFromDataRowToDepartment(dataRow));
            }

            return departments;

        }
        public static Department GetDepartmentByID(int _depertmentID)
        {
            Department department = new Department();
            string query = $"select * from department where ID={_depertmentID}";

            DataTable dt = DBManager.ExecuteSelectedDisconnect(query);

            if (dt.Rows.Count > 0) return ConvertFromDataRowToDepartment(dt.Rows[0]);

            return department; // defult ctor 
        }

        private static Department ConvertFromDataRowToDepartment(DataRow row)
        {
            Department department = new Department();
            #region Mapping
            if (int.TryParse(row["ID"].ToString(), out int id)) { department.ID = id; }

            department.Name = row["Name"].ToString();

            if (int.TryParse(row["Capacity"].ToString(), out int capacity)) { department.Capacity = capacity; }
            #endregion
            return department;
        }

        public static int InsertDepartment(Department _department)
        {
            string query = $"INSERT INTO Department (Name,Capacity) VALUES('{_department.Name}',{_department.Capacity});";

            return DBManager.ExecuteNonQuery(query);
        }
    }
}
