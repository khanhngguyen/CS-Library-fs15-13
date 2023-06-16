namespace User;
using Interface;

class Customer : Person, ICustomer
{
    private readonly string _role = String.Empty;

    public string Role
    {
        get { return _role; }
    }

    public Customer(string name) : base(name)
    {
        Name = name;
        _role = "customer";
    }
}