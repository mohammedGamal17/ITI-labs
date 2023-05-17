namespace _4
{
    internal class Program
    {
        static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }

        public static Func<Book, string> GetPublicationDate = (b) => b.PublicationDate.ToString();

        static void Main(string[] args)
        {
            string[] Authors = new[] { "Mohammed", "Gamal" };
            Book book = new Book("1", "MG", Authors, DateTime.Now, 1000);
            Book book1 = new Book("2", "MM", Authors, DateTime.Now, 2000);
            Book book2 = new Book("3", "GG", Authors, DateTime.Now, 3000);

            List<Book> bList = new List<Book>();
            bList.Add(book);
            bList.Add(book1);
            bList.Add(book2);

            // User Defined Delegate Datatype
            LibraryEngine.ProcessBooks(bList, BookFunctions.GetTitle);
            Console.WriteLine("*******************************************");

            LibraryEngine.ProcessBooks(BookFunctions.GetAuthors, bList);
            Console.WriteLine("*******************************************");

            LibraryEngine.ProcessBooks(GetPrice, bList);
            Console.WriteLine("*******************************************");

            LibraryEngine.ProcessBooks(GetPublicationDate, bList);
            Console.WriteLine("*******************************************");

            Console.ReadKey();
        }


    }
}


