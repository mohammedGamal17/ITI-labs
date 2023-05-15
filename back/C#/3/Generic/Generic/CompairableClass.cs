namespace Generic
{
    internal class CompairableClass : IComparable<CompairableClass>
    {
        public int CompareTo(CompairableClass? other)
        {
            Console.WriteLine("IComparable ");
            throw new NotImplementedException();
        }
    }
}
