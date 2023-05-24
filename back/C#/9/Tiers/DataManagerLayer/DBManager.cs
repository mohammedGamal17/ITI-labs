using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBManager
    {
        static string conn = "Data Source=.;Initial Catalog=ITI;Integrated Security=True; Encrypt=false;";
        public static DataTable ExecuteSelectedDisconnect(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string command)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();

            int x = sqlCommand.ExecuteNonQuery();

            return x;
        }
    }
}
