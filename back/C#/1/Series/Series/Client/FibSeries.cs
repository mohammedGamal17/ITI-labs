using Series.Interfaces;

namespace Series.Client
{
    internal class FibSeries : ISeries
    {
        int prevCurrent = 1;
        int current = 2;
        int result;
        public int GetSeries()
        {
            result = prevCurrent + current;
            prevCurrent = current;
            return result;
        }
    }
}
