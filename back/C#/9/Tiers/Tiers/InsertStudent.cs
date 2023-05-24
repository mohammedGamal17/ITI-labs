using DataBasinessLayer;

namespace Tiers
{
    public partial class InsertStudent : Form
    {
        string _studentName;
        uint _age;

        public int Depertment_ID { get; set; }

        Department department = null;
        public InsertStudent(int _id)
        {
            InitializeComponent();
            Depertment_ID = _id;
        }

        private void InsertStudent_Load(object sender, EventArgs e)
        {
            department = DepartmentManager.GetDepartmentByID(Depertment_ID);
            Text = department.Name;
            lblDepertment.Text = department.Name;
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                errorProvider1.SetError(txtName, "Please enter your name.");
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
                errorProvider1.Clear();
            }
        }

        private void txtAge_Validated(object sender, EventArgs e)
        {
            if (!uint.TryParse(txtAge.Text, out _age))
            {
                txtAge.Focus();
                errorProvider2.SetError(txtAge, "Please enter valid Age.");

            }
            else
            {
                errorProvider2.SetError(txtAge, string.Empty);
                errorProvider2.Clear();

            }
        }

        private void btnInseret_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtName.Text;
            student.Age = (int)_age;
            student.DepartmentID = Depertment_ID;

            StudentManager.InsertStudent(student);
            MessageBox.Show($"Inserted\n{student.Name},{student.Age},{student.DepartmentID}");
        }
    }
}
