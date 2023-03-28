using System;

namespace ConsoleAppDealingWithAbstractAndTimeConstrains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration = new Duration(99);
            Duration duration2 = new Duration(88);

            Duration duration3 = duration + duration2;

            if (duration > duration2) Console.WriteLine($"{duration.Seconds} > {duration2.Seconds}");
            if (duration < duration2) Console.WriteLine($"{duration.Seconds} < {duration2.Seconds}");
            Console.WriteLine(duration3.Print());
            Console.ReadLine();
        }
    }
}
