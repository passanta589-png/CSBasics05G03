namespace CS_Basics05G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            Book book = new Book();
            Console.WriteLine(book.password);

            #endregion
            #region 02

            Console.WriteLine(book.copiesInStock);

            #endregion

        }
    }
}
