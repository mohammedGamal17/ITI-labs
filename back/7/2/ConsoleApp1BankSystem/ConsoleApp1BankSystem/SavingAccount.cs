namespace ConsoleApp1BankSystem
{
    internal class SavingAccount : Account
    {
        #region Fields
        private double percentage;
        #endregion

        #region Constructors
        public SavingAccount(double _balance, double _percentage) : base(_balance)
        {
            Percentage = _percentage;
        }
        #endregion

        #region Properties
        public double Percentage
        {
            get { return percentage; }
            set
            {
                if (value > 100) { percentage = 1; } else { percentage = value; }

            }
        }
        #endregion

        #region Methods
        public double calculateInterest()
        {
            double oldBalance = Balance;
            double newBalance = ((percentage / 100) * Balance);
            return Balance += newBalance;
        }
        #endregion

    }
}
