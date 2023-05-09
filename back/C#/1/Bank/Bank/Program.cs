using Bank.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Bank
        //List<BankAccount> accounts = new List<BankAccount>();
        //accounts.Add(new BankAccount("123456789", "Mohammed Gamal", 5000));
        //accounts.Add(new BankAccount("456789123", "Mahmoud Gamal", 8000));
        //accounts.Add(new BankAccount("987654321", "Ahmed Gamal", 3000));


        //accounts.Sort(); // Sort by account balance

        //foreach (var account in accounts)
        //{
        //    Console.WriteLine(account.ToString());
        //}

        #endregion

        #region IClone
        Clone c1 = new Clone { ID = 1, Name = "Mohammed Gamal" };
        Clone c2 = (Clone)c1;


        c2.ID = 2; c2.Name = "Ahmed";
        Console.WriteLine("\t\tBefore MyClass");
        Console.WriteLine(c1.ToString());
        Console.WriteLine("\t\tAfter MyClass");
        Console.WriteLine(c2.ToString());
        #endregion

        #region TwoInterfaces
        //MyClass obj = new MyClass();

        //((IBM)obj).Print();
        //((AWS)obj).Print();
        #endregion

        Console.ReadKey();
    }
}