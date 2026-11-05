namespace Biblioteka
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
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
}