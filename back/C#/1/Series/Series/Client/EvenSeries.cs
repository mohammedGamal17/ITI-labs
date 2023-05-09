using Series.Interfaces;

namespace Series.Client
{
    internal class EvenSeries : ISeries
    {
        int current = 0;

        public int GetSeries()
        {
            return current += 2;
        }
    }
}
