namespace User;
using Interface;
using Books;
using Libraries;

class Librarian : Person, ILibrarian
{
    private readonly string _role = String.Empty;

    public string Role
    {
        get { return _role; }
    }

    public void AddBookToLibrary(Book book, Library library)
    {
        if (library.HasUser(this))
        {
            library.AddBook(book);
        }
        else throw new Exception($"This librarian is not in {library.Name} Library");
    }
    public void RemoveBookFromLibrary(Book book, Library library)
    {
        if (library.HasUser(this))
        {
            library.RemoveBook(book);
        }
        else throw new Exception($"This customer is not in {library.Name} Library");
    }
    public void EditBookInLibrary(Book book, Library library, string? title, string? author, int? year)
    {
        if (library.HasUser(this))
        {
            library.EditBook(book, title, author, year);
        }
        else throw new Exception($"This customer is not in {library.Name} Library");
    }

    public Librarian(string name) : base(name)
    {
        Name = name;
        _role = "librarian";
    }
}