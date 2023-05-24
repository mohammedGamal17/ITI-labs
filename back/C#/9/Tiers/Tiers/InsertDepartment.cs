using DataBasinessLayer;

namespace Tiers
{
    public partial class InsertDepartment : Form
    {
        string _depName;
        uint _capacity;
        public InsertDepartment()
        {
            InitializeComponent();
        }

        private void InsertDepartment_Load(object sender, EventArgs e)
        {

        }

        private void txtDepName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepName.Text))
            {
                txtDepName.Focus();
                errorProvider1.SetError(txtDepName, "Please enter your name.");
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                errorProvider1.SetError(txtDepName, string.Empty);
                errorProvider1.Clear();
            }
        }

        private void txtDepCapacity_Validated(object sender, EventArgs e)
        {

            if (!uint.TryParse(txtDepCapacity.Text, out _capacity))
            {
                txtDepCapacity.Focus();
                errorProvider2.SetError(txtDepCapacity, "Please enter valid capacity.");

            }
            else
            {
                errorProvider2.SetError(txtDepCapacity, string.Empty);
                errorProvider2.Clear();

            }
        }

        private void btnInseret_Click(object sender, EventArgs e)
        {

            Department department = new Department();
            department.Name = txtDepName.Text;
            department.Capacity = (int)_capacity;


            int m = DepartmentManager.InsertDepartment(department);

            MessageBox.Show($"Inserted");


        }

        private void txtDepName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
