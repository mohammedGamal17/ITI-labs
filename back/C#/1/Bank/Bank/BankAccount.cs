namespace Bank
{
    internal class BankAccount : IComparable<BankAccount>
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        // Constructor
        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public int CompareTo(BankAccount? other)
        {
            if (other == null) return 1;
            return this.Balance.CompareTo(other.Balance);
        }

        public override string ToString()
        {
            return "Account: " + AccountNumber + " " + AccountHolderName + " " + Balance;
        }
    }
}

