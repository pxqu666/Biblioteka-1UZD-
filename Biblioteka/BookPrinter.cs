namespace Biblioteka
{
    public class BookPrinter
    {
        public void Print(Book book)
        {
            string status = book.IsBorrowed ? "izsniegta" : "brîva";
            Console.WriteLine($"{book.Title} ({book.Author}) - {status}");
        }
    }
}