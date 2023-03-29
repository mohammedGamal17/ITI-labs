using System;

namespace ConsoleApp1BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dealing with CheckingAccount
            //CheckingAccount checkingAccount = new CheckingAccount(1000, 3);
            //Console.WriteLine(checkingAccount.getBalance());

            //checkingAccount.credit(5);

            //Console.WriteLine(checkingAccount.getBalance());

            //checkingAccount.debit(5);

            //Console.WriteLine(checkingAccount.getBalance());
            #endregion

            #region Dealing with SavingAccount
            SavingAccount savingAccount = new SavingAccount(1000, 50000);

            Console.WriteLine(savingAccount.calculateInterest());
            #endregion
            Console.ReadLine();
        }
    }

}
