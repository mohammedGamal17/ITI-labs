using System;

namespace SingleTone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singletone = Singleton.getInstance();
            Singleton singletone2 = Singleton.getInstance();


            Console.WriteLine(singletone.Counter);  // 0
            singletone.Counter++; // 1
            Console.WriteLine(singletone2.Counter); // 1
            singletone.Counter++; // 1
            Console.WriteLine(singletone.Counter); // 2

            Console.ReadKey();
        }
    }
}
