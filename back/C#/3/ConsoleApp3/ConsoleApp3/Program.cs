namespace ConsoleApp3
{
    internal class Program
    {
        public static void Swap<t>(ref t a, ref t b)
        {
            t temp = a;
            a = b;
            b = temp;
        }
        public static void Any<t>(t a, t b) where t : IComparable
        {
            a.CompareTo(b);
        }
        public static void Any2<t>(t a, t b) where t : class, ICloneable, new()
        {
            a.Clone();
            b.Clone();
        }


        static void Main(string[] args)
        {
            #region Swap
            int r1 = 10;
            int r2 = 20;
            float r3 = 2.3f;
            float r4 = 5.4f;
            double r5 = 3.678;
            double r6 = 8.56;
            Console.WriteLine($"before r1:{r1}, r2:{r2}");
            Swap(ref r1, ref r2);
            Console.WriteLine($" after r1:{r1}, r2:{r2}");

            Console.WriteLine("-------------------------");
            Console.WriteLine($"before r3:{r3}, r4:{r4}");
            Swap(ref r3, ref r4);
            Console.WriteLine($"after r3:{r3}, r4:{r4}");

            Console.WriteLine("-------------------------");
            Console.WriteLine($"before r5:{r5}, r6:{r6}");
            Swap(ref r5, ref r6);
            Console.WriteLine($"after r5:{r5}, r6:{r6}");
            #endregion
            #region list of string 
            List<string> l1 = new List<string>();
            l1.Add("Mohammed");
            l1.Add("Gamal");
            l1.AddRange(new string[] { "menna", "mohammed", "ahmed", "mahmoud" });
            l1.RemoveAt(1);
            l1.ForEach(x => Console.WriteLine(x));
            #endregion
            #region list of int
            List<int> l2 = new List<int>();
            l2.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            l2.ForEach(x => Console.WriteLine(x));
            #endregion
            #region list of persons
            List<Person> l3 = new List<Person>();
            l3.AddRange(new Person[] { new Person("Gamal", 25, 'f'), new Person("manal", 26, 'f'), new Person("mohammed", 27, 'm') });
            l3.ForEach(x => Console.WriteLine(x.ToString()));
            #endregion
            #region dictionary
            Dictionary<Person, int> dic = new Dictionary<Person, int>();
            dic.Add(new Person("Gamal", 25, 'f'), 1);
            dic.Add(new Person("mohammed", 26, 'm'), 2);
            foreach (KeyValuePair<Person, int> item in dic)
            {
                Console.WriteLine($"{item.Key.ToString()}...{item.Value}");
            }
            #endregion
            Console.WriteLine("-----------------------------------------------------");
            MyList l = new MyList();
            Person p1 = new Person("Mohammed", 24, 'f');
            Person p2 = new Person("Gamal", 24, 'f');
            l.Add(p1);
            l.Add(p2);




        }
    }
}