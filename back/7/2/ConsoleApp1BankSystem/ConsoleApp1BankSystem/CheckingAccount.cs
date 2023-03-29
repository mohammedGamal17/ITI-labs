using System;

namespace ConsoleApp1BankSystem
{
    internal class CheckingAccount : Account
    {

        #region Fields
        private double fees;
        #endregion

        #region Constructors
        public CheckingAccount(double _balance, double _fees) : base(_balance)
        {
            Fees = _fees;
        }
        #endregion

        #region Properties
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        #endregion

        #region Methods
        public override double credit(float _deposit)
        {
            return Balance += (_deposit - Fees);
        }

        public override double debit(float _widthdraw)
        {
            if (Balance - _widthdraw > 0) { return Balance -= (_widthdraw + Fees); }
            Console.WriteLine("Debit amount exceeded account balance");
            return Balance;
        }
        #endregion
    }
}
