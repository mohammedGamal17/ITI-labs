using System.Diagnostics.CodeAnalysis;

namespace D_04
{
    internal class CompareDic : IEqualityComparer<BankAccount>
    {
        public bool Equals(BankAccount? x, BankAccount? y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode([DisallowNull] BankAccount obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
