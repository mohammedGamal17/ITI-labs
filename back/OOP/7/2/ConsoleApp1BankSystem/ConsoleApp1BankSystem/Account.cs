using System;

namespace ConsoleApp1BankSystem
{
    class Account
    {
        #region Fields
        private double balace;
        #endregion

        #region Constructors
        public Account(double _balance)
        {
            Balance = _balance;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return balace; }
            set { balace = value; }
        }
        #endregion

        #region Methods
        public virtual double credit(float _deposit)
        {
            return Balance += _deposit;
        }

        public virtual double debit(float _widthdraw)
        {
            if (Balance - _widthdraw > 0) { return Balance -= _widthdraw; }
            Console.WriteLine("Debit amount exceeded account balance");
            return Balance;
        }
        public double getBalance()
        {
            return Balance;
        }
        #endregion

    }
}
