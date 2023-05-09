namespace Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(10, 20);
            Complex complex2 = new Complex(20, 30);


            Console.WriteLine(complex1.Add(complex2));
            Console.WriteLine(complex1 + complex2);

            Console.WriteLine(complex1 + 10);
            Console.WriteLine(20 + complex1);
            Console.WriteLine(complex1++);

            double explicitOpr = complex1.Real;
            Console.WriteLine(explicitOpr);

            Console.WriteLine(complex1.CompareTo(complex2));
            Console.ReadKey();
        }
    }
}
