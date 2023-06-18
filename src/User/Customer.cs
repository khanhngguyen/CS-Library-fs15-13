namespace User;
using Interface;
using Books;
using Libraries;

class Customer : Person, ICustomer
{
    private readonly string _role = String.Empty;

    public string Role
    {
        get { return _role; }
    }

    public void Borrow(Book book, Library library)
    {
        if (library.HasCustomer(this))
        {
            library.BorrowBook(book);
        }
        else throw new Exception($"This customer is not in {library.Name} Library");
    }
    public void Return(Book book, Library library)
    {
        if (library.HasCustomer(this))
        {
            library.ReturnBook(book);
        }
        else throw new Exception($"This customer is not in {library.Name} Library");
    }

    public Customer(string name) : base(name)
    {
        Name = name;
        _role = "customer";
    }
}