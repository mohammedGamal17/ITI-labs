namespace SingleTone
{
    #region Single Thread
    internal sealed class Singleton
    {
        private Singleton() { }

        private static Singleton instance = null;

        public static Singleton getInstance()
        {
            if (instance == null) return instance = new Singleton();
            return instance;
        }


        private int counter = 0;

        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
    }
    #endregion


    #region Multi Thread

    internal sealed class Songleton2
    {
        private Songleton2() { }

        private static Songleton2 instance = null;

        private static object lockObj = new object();

        #region One-Check Locking
        //public static Songleton2 getInstance()
        //{
        //    lock (lockObj)
        //    {
        //        if (instance == null) return instance = new Songleton2();
        //    }
        //    return instance;
        //}
        #endregion

        #region Double-Check Locking
        public static Songleton2 getInstance()
        {
            // Double-Check Locking
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null) return instance = new Songleton2();
                }
            }
            return instance;
        }
        #endregion

    }
    #endregion

}
