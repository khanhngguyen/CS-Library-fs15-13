namespace Libraries;
using Books;
using User;
class Library
{
    private string _name = String.Empty;
    private readonly HashSet<Book> _books = new HashSet<Book>();
    private readonly HashSet<Book> _borrowedBooks = new HashSet<Book>();
    private readonly HashSet<string> _booksTitles = new HashSet<string>();
    private HashSet<Person> _users = new HashSet<Person>();

    public string Name 
    {
        get { return _name; }
        set 
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentException("Name can not be empty");
            else _name = value;
        }
    }

    public HashSet<Book> Books
    {
        get { return _books; }
    }

    public Library(string name)
    {
        Name = name;
    }

    public bool AddBook(Book book)
    {
        if (_books.Contains(book)) return false;
        else 
        {
            _books.Add(book);
            _booksTitles.Add(book.Title.ToLower());
            return true;
        }
    }
    public Book GetBook(Book book)
    {
        if (_books.Contains(book))
        {
            book.PrintInfo();
            return book;
        }
        else throw new ArgumentException("Can not find book");
    }
    public void SearchBookByTitle(string name)
    {
        if (_booksTitles.Contains(name.ToLower()))
        {
            IEnumerable<Book> result = _books.Where(book => book.Title == name);
            foreach (Book item in result)
            {
                Console.WriteLine("Search result:");
                item.PrintInfo();
            }
        }
        else throw new ArgumentException($"Can not find any book with name {name}");
    }
    public bool RemoveBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            return true;
        }
        else throw new ArgumentException("Can not find book to remove");
    }
    public bool BorrowBook(Book book)
    {
        if (_books.Contains(book))
        {
            _borrowedBooks.Add(book);
            _books.Remove(book);
            Console.WriteLine($"Book: {book.Title} is borrowed");
            return true;
        }
        else throw new ArgumentException($"Can not find book {book.Title} in the library");
    }
    public bool ReturnBook(Book book)
    {
        if (_borrowedBooks.Contains(book))
        {
            _books.Add(book);
            _borrowedBooks.Remove(book);
            Console.WriteLine($"Return book: {book.Title} back to library successfully");
            return true;
        }
        else throw new ArgumentException($"Can not return this book");
    }
}