using Operadores;
using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double FNum { get; set; }
        public double SNum { get; set; }
        public string Operator { get; set; }

        Form2 history = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        Add add = new Add();
        Subtraction sub = new Subtraction();
        Multiplicacao mul = new Multiplicacao();
        Division div = new Division();


        private void button0_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 7)
            {
                input.Text = input.Text + "9";
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            Operator = "*";
            FNum = double.Parse(input.Text);
            input.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operator = "+";
            FNum = double.Parse(input.Text);
            input.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Operator = "-";
            FNum = double.Parse(input.Text);
            input.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Operator = "/";
            FNum = double.Parse(input.Text);
            input.Clear();
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            SNum = double.Parse(input.Text);
            switch (Operator)
            {
                case "+":
                    output.Text = add.AddNumbers(FNum, SNum).ToString();
                    break;
                case "-":
                    output.Text = sub.RealizaSub(FNum, SNum).ToString();
                    break;
                case "X":
                    output.Text = mul.RealizaMulti(FNum, SNum).ToString();
                    break;
                case "/":
                    if (SNum == 0)
                    {
                        output.Text = "Math Error";
                    }
                    else
                        output.Text = div.RealizaDiv(FNum, SNum).ToString();
                    break;
            }
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{FNum} {Operator} {SNum} = {output.Text}\n");

            history.SetFNumAndSNum((int)FNum, (int)SNum, Operator, output.Text);

            input.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure that you would like to cancel the Calculator ?";
            const string caption = "Cancel Calculator";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            history.ShowDialog();
        }
    }
}