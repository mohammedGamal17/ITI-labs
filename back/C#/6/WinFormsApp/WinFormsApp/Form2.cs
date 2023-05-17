namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Mohammed Gamal";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1;
            int num2;
            int num3;
            for (int i = 0; i < 1; i++)
            {
                num1 = rnd.Next(0, 255);
                num2 = rnd.Next(0, 255);
                num3 = rnd.Next(0, 255);
                this.BackColor = Color.FromArgb(num1, num2, num3);
                this.Refresh();
                Thread.Sleep(50);
            }
        }

        private void showText_Click(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
