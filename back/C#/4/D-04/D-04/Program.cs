namespace D_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount() { ID = 1, Name = "Mohammed", Salary = 7500 };
            BankAccount account2 = new BankAccount() { ID = 1, Name = "Mohammed", Salary = 7800 };
            BankAccount account3 = new BankAccount() { ID = 2, Name = "Ahmed", Salary = 7300 };

            #region Ckeck Equality
            Console.WriteLine("********************** Ckeck Equality **********************");

            Console.WriteLine(account1.Equals(account2));
            #endregion



            BankAccount[] bankAccounts = new BankAccount[] { account1, account2, account3 };

            #region Sort Array by Name
            Console.WriteLine();
            Console.WriteLine("*********************** Name Sort ***************************");


            Array.Sort(bankAccounts);
            foreach (var item in bankAccounts) Console.WriteLine(item);

            #endregion

            #region Sort Array by ID
            Console.WriteLine();

            Console.WriteLine("*********************** Salary Sort **************************");

            SalarySort salarySort = new SalarySort();
            Array.Sort(bankAccounts, salarySort);
            foreach (var item in bankAccounts) Console.WriteLine(item);
            #endregion

            #region Dictionary
            Console.WriteLine();
            Console.WriteLine("*********************** Dictionary Sort **************************");

            Dictionary<BankAccount, int> accountDictionary = new Dictionary<BankAccount, int>();

            try
            {
                accountDictionary.Add(account1, 1);
                accountDictionary.Add(account2, 2);
                accountDictionary.Add(account3, 3);
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

            foreach (var item in accountDictionary) Console.WriteLine(item);
            #endregion

            #region Hash Set
            Console.WriteLine();
            Console.WriteLine("*********************** Dictionary Sort **************************");

            HashSet<BankAccount> accountsSet = new HashSet<BankAccount>();
            accountsSet.Add(account1);
            accountsSet.Add(account2);
            accountsSet.Add(account3);
            accountsSet.Add(account3);

            foreach (var item in accountsSet) Console.WriteLine(item);
            #endregion

            Console.ReadLine();
        }
    }
}