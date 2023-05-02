using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Print Hello World
            //Console.WriteLine("Hello World!");

            #endregion
            #region convert char to ASCII
            //Console.Write("Enter Your Character : ");
            //char ch = char.Parse(Console.ReadLine());

            //int ascii = (int)ch;
            //Console.WriteLine($"char {ch} == in ascii {ascii}");
            #endregion
            #region convert ASCII to char
            //Console.Write("Enter Your Number : ");
            //int num = int.Parse(Console.ReadLine());

            //char c = (char)num;
            //string s = c.ToString();

            //Console.WriteLine($"in ascii {s} == Char {num}");
            #endregion
            #region convert decimal to hexa
            //Console.Write("Enter Your number : ");
            //int num = int.Parse(Console.ReadLine());
            //string outputHex = num.ToString("X");
            //Console.WriteLine($"number in decimal {num} == in hexa {outputHex}");
            #endregion


            #region small calulator of two number
            Console.Write("Enter your First Number = ");
            int fnumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your Second Number = ");
            int snumber = int.Parse(Console.ReadLine());

            Console.WriteLine("sum " + (fnumber + snumber));
            Console.WriteLine("multiplication " + (fnumber * snumber));
            if (snumber == 0)
            {
                Console.WriteLine("Math Error");

            }
            else
            {
                Console.WriteLine("divition " + (fnumber / snumber));
            }


            #endregion
            Console.ReadKey();
        }
    }
}
