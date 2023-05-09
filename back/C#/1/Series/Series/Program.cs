using Series.Client;

namespace Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenSeries evenSeries = new EvenSeries();
            OddSeries oddSeries = new OddSeries();
            FibSeries fibSeries = new FibSeries();


            Concrete concrete = new Concrete();

            Console.WriteLine(concrete.GetSeries(evenSeries));
            Console.WriteLine(concrete.GetSeries(oddSeries));
            Console.WriteLine(concrete.GetSeries(fibSeries));
        }
    }
}