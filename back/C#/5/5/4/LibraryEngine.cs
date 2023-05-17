namespace _4
{
    internal class LibraryEngine
    {

        public delegate string BookFunctionDelegate(Book b);
        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }


        public static void ProcessBooks(Func<Book, string> fPtr, List<Book> bList)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

    }
}

