namespace ConsoleAppDealingWithAbstractAndTimeConstrains
{
    internal class Duration
    {
        public Duration() { }
        public Duration(uint _seconds)
        {
            Seconds = _seconds;
        }
        public Duration(uint _minutes, uint _seconds)
        {
            Seconds = _seconds;
            Minutes = _minutes;
        }
        public Duration(uint _hours, uint _minutes, uint _seconds)
        {
            Seconds = _seconds;
            Minutes = _minutes;
            Hours = _hours;
        }

        public uint Seconds { get; set; }
        public uint Minutes { get; set; }
        public uint Hours { get; set; }

        public string Print()
        {
            uint hours = Seconds / 3600;
            uint minutes = (Seconds % 3600) / 60;
            uint seconds = (Seconds % 60);


            if (hours > 0)
                return $"{hours} hours, {minutes} minutes, {seconds} seconds";
            else if (minutes > 0)
                return $"{minutes} minutes, {seconds} seconds";
            else
                return $"{seconds} seconds";
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration() { Seconds = d1.Seconds + d2.Seconds };
        }

        public static Duration operator +(Duration d1, uint _sec)
        {
            return new Duration() { Seconds = d1.Seconds + _sec };
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.Seconds > d2.Seconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Seconds < d2.Seconds;
        }
    }
}
