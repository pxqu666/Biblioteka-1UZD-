namespace Biblioteka
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        //IsBorrowed ir private set, jo tikai Book klase var mainit so stavokli caur Borrow() un Return() metodem, nodrosinot datu drosibu.
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public bool Borrow()
        {
            if (IsBorrowed)
            {
                return false;
            }
            IsBorrowed = true;
            return true;
        }

        public bool Return()
        {
            if (!IsBorrowed)
            {
                return false;
            }
            IsBorrowed = false;
            return true;
        }
    }

    //BookPrinter ir atseviska klase, jo ta atbild tikai par gramatas informacijas atteloðanu, nevis pasas gramatas stavokla parvaldibu (Single Responsibility Principle).
    public class BookPrinter
    {
        public void Print(Book book)
        {
            string status = book.IsBorrowed ? "izsniegta" : "brîva";
            Console.WriteLine($"{book.Title} ({book.Author}) - {status}");
        }
    }
}