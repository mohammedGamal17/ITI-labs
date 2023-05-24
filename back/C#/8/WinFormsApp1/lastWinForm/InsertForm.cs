using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lastWinForm
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        string ConnectionString = "server=.;database=ITICSharp;integrated security=true;encrypt=false;";
        private void InsertForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == 0)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from department", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr["Name"]);
                }
                if(comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    if (conn.State == 0)
                        conn.Open();

                    int selectedDepartment = comboBox1.SelectedIndex + 1;

                    SqlCommand cmd = new SqlCommand($"insert into student(Name,age,DepartmentId) values('{textBox1.Text}',{Convert.ToInt32(textBox2.Text)},{selectedDepartment})", conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    
                    MessageBox.Show("Student was added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Name and Age cannot be empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
