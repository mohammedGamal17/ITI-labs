using Series.Interfaces;

namespace Series.Client
{
    internal class OddSeries : ISeries
    {
        int current = 1;

        public int GetSeries()
        {
            return current += 2;
        }
    }
}
