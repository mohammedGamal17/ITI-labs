namespace D_04
{
    internal class SalarySort : IComparer<BankAccount>
    {
        public int Compare(BankAccount? acc1, BankAccount? acc2)
        {
            return acc1.Salary.CompareTo(acc2.Salary);
        }
    }
}
