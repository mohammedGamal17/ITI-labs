namespace Bank.Interfaces
{
    interface IBM
    {
        void Print();
    }

    interface AWS
    {
        void Print();
    }

    class MyClass : IBM, AWS
    {
        void IBM.Print()
        {
            Console.WriteLine("IBM.Print");
        }

        void AWS.Print()
        {
            Console.WriteLine("AWS.Print");
        }
    }
}
