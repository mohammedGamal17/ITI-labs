namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            double x = 1.5, y = 2.5;
            Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            float m = 3.1f, n = 4.2f;
            Swap(ref m, ref n);
            Console.WriteLine("m = {0}, n = {1}", m, n);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }
    }
}