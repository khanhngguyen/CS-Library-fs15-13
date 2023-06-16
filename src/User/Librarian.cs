namespace User;
using Interface;

class Librarian : Person, ILibrarian
{
    private readonly string _role = String.Empty;

    public string Role
    {
        get { return _role; }
    }

    public Librarian(string name) : base(name)
    {
        Name = name;
        _role = "librarian";
    }
}