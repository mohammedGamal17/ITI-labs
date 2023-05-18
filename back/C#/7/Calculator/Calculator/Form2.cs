namespace Calculator
{
    public partial class Form2 : Form
    {
        private int FNum { get; set; }
        private int SNum { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public void SetFNumAndSNum(int fNum, int sNum, string oper, string result)
        {
            FNum = fNum;
            SNum = sNum;

            Data.Text += $"{fNum} {oper} {sNum} = {result}\n";

        }


    }
}
