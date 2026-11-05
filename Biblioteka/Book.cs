namespace Biblioteka
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        //IsBorrowed ir private set, jo tikai Book klase var mainît ðo stâvokli caur Borrow() un Return() metodçm, nodroðinot datu droðîbu.
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

    //BookPrinter ir atseviðía klase, jo tâ atbild tikai par grâmatas informâcijas attçloðanu, nevis paðas grâmatas stâvokïa pârvaldîbu (Single Responsibility Principle).
    public class BookPrinter
    {
        public void Print(Book book)
        {
            string status = book.IsBorrowed ? "izsniegta" : "brîva";
            Console.WriteLine($"{book.Title} ({book.Author}) - {status}");
        }
    }
}