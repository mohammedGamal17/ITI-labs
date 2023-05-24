using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace lastWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtStudent;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "server=.;database=ITICSharp;integrated security=true;encrypt=false;";

                SqlDataAdapter StudentAdapter = new SqlDataAdapter("select * from Student", ConnectionString);
                dtStudent = new DataTable();
                StudentAdapter.Fill(dtStudent);
                dataGridView1.DataSource = dtStudent;

                dataGridView1.Columns["departmentId"].Visible = false;

                SqlDataAdapter departmentAdapter = new SqlDataAdapter("select * from department", ConnectionString);
                DataTable dtDepartment = new DataTable();
                departmentAdapter.Fill(dtDepartment);

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = "Department Name";
                comboBoxColumn.DisplayMember = "Name";
                comboBoxColumn.ValueMember = "Id";
                comboBoxColumn.DataSource = dtDepartment;
                comboBoxColumn.DataPropertyName = "Id";
                dataGridView1.Columns.Add(comboBoxColumn);

                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.DataSource = dtDepartment;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //To avoid CurrencyManager exception error
                dataGridView1.CurrentCell = null;

                for (int i = 0; i < dtStudent.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1["Id", i].Value) != Convert.ToInt32(comboBox1.SelectedValue))
                        dataGridView1.Rows[i].Visible = false;
                    else
                        dataGridView1.Rows[i].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.Show();
        }
    }
}