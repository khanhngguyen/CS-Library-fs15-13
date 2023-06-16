using System;
namespace User;
using Interface;

class Person
{
    private readonly Guid _id;
    private string _name = String.Empty;

    public Guid Id
    {
        get { return _id; }
    }
    public string Name
    {
        get { return _name; }
        set
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentException("Name can not be empty");
            else _name = value;
        }
    }

    public Person(string name)
    {
        _id = Guid.NewGuid();
        Name = name;
    }
}