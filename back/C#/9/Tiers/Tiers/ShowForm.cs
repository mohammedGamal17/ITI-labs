using DataBasinessLayer;

namespace Tiers
{
    public partial class ShowForm : Form
    {
        int departmentID;
        public ShowForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartments.DisplayMember = "Name";
            cmbDepartments.ValueMember = "ID";
            cmbDepartments.DataSource = DepartmentManager.GatAllDepartments();
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentID = (int)cmbDepartments.SelectedValue;

            cmbStudents.DisplayMember = "Name";
            cmbStudents.ValueMember = "ID";
            cmbStudents.DataSource = StudentManager.GetDepartmentStudent(departmentID);
        }

        private void btnInsertDep_Click(object sender, EventArgs e)
        {
            InsertDepartment insertForm = new InsertDepartment();

            insertForm.Show();
        }

        private void btnInsertStu_Click(object sender, EventArgs e)
        {
            InsertStudent insertStudent = new InsertStudent(departmentID);

            insertStudent.Show();
        }
    }
}