namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage respnese = httpClient.GetAsync("https://localhost:7111/api/Department").Result;

            if (respnese.IsSuccessStatusCode)
            {
                List<Department> departments = respnese.Content.ReadAsAsync<List<Department>>().Result;

                dgvDept.DataSource = departments;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxName.Text != null && txtbxDesc != null)
            {
                Department department = new Department()
                {
                    Name = txtbxName.Text,
                    Description = txtbxDesc.Text,
                };
                HttpClient httpClient = new HttpClient();

                HttpResponseMessage respnese = httpClient.PostAsJsonAsync("https://localhost:7111/api/Department", department).Result;

                if (respnese.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Success {respnese.StatusCode}");

                    Form1_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid data");
            }




        }
    }
}