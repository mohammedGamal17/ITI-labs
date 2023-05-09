using Series.Interfaces;

namespace Series.Client
{
    internal class Concrete
    {
        public int GetSeries(ISeries series)
        {
            return series.GetSeries();
        }
    }
}
