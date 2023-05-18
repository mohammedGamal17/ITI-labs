namespace AnimationCircle
{
    public partial class Form2 : Form
    {

        int x = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            drawCircle(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(this.BackColor);


            graphics.FillEllipse(brush, x, 200, 100, 75);
            x += 20;

            if (x >= MaximumSize.Width)
            {
                x = 0;
            }
            drawCircle(graphics);
        }


        void drawCircle(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Blue, x, 200, 100, 75);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) { button1.Text = "Stop"; }
            else { button1.Text = "Start"; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
