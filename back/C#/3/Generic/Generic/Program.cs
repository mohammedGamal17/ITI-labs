namespace Generic
{
    internal class Program
    {
        #region Generic Swap
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Generic Compairable

        public static void checkIComparable<T>(T obj) where T : IComparable<T>
        {

            Console.WriteLine("Implement IComparable");

        }
        #endregion

        #region Accept only referande object

        public void checkICloneable<T>(T obj) where T : class, ICloneable, new()
        {


            Console.WriteLine("Implement ICloneable");

        }
        #endregion
        static void Main(string[] args)
        {
            #region Generic Swap
            int x = 5, y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
            #endregion

            #region Generic Compairable
            CompairableClass testClass = new CompairableClass();
            checkIComparable(testClass);
            #endregion

            #region Accept only referande object
            CloneClass cloneClass = new CloneClass(10);
            checkICloneable(cloneClass);
            #endregion
            Console.ReadKey();
        }
    }
}