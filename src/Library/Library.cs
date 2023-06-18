namespace Libraries;
using Books;
using User;
class Library
{
    private string _name = String.Empty;
    private readonly HashSet<Book> _books = new HashSet<Book>();
    private readonly HashSet<Book> _borrowedBooks = new HashSet<Book>();
    private readonly HashSet<string> _booksTitles = new HashSet<string>();
    private readonly HashSet<Person> _users = new HashSet<Person>();

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
    public HashSet<Person> Users
    {
        get { return _users; }
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
    public void GetAllBooks()
    {
        Console.WriteLine("All available books in library:");
        foreach (Book book in _books)
        {
            book.PrintInfo();
        }
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
            if (book.CanBorrow)
            {
                _borrowedBooks.Add(book);
                _books.Remove(book);
                Console.WriteLine($"Book: {book.Title} is borrowed");
                return true;
            }
            else 
            {
                Console.WriteLine("This book can not be borrowed");
                return false;
            }
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
        else throw new ArgumentException("Can not return this book");
    }
    public void EditBook(Book book, string? title, string? author, int? year)
    {
        if (_books.Contains(book))
        {
            var found = _books.FirstOrDefault(b => b.ISBN == book.ISBN);
            if (found == null) throw new Exception();
            else 
            {
                if (title != null) found.Title = title;
                if (author != null) found.Author = author;
                if (year.HasValue) found.PublicationYear = (int) year;
            }
        }
        else throw new ArgumentException($"Can not find book: {book.Title} in library to edit");
    }
    public bool AddUser(Person user)
    {
        if (_users.Contains(user)) return false;
        else
        {
            _users.Add(user);
            return true;
        }
    }
    public bool RemoveUser(Person user)
    {
        if (_users.Contains(user))
        {
            _users.Remove(user);
            return true;
        }
        else throw new ArgumentException("Can not remove, user is not in this library");
    }
    public void EditUser(Person user, string name)
    {
        if (_users.Contains(user))
        {
            var found = _users.FirstOrDefault(u => u.Id == user.Id);
            if (found == null) throw new Exception();
            else found.Name = name;
        }
        else throw new ArgumentException("Can not edit, user is not in this library");
    }
    public bool HasUser(Person user)
    {
        return _users.Contains(user);
    }
}