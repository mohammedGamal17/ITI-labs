namespace _4
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string authors = string.Join(", ", B.Authors);
            return authors;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }




    }
}
