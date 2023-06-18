using System;
namespace Books;

abstract class Book
{
    private readonly Guid _isbn;
    private string _title = String.Empty;
    private string _author = String.Empty;
    private int _publicationYear;

    public Guid ISBN
    {
        get { return _isbn; }
    }
    public string Title
    {
        get { return _title; }
        set 
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentException("Title can not be empty");
            else _title = value;
        }
    }
    public string Author
    {
        get { return _author; }
        set 
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentException("Author can not be empty");
            else _author = value;
        }
    }
    public int PublicationYear 
    {   get { return _publicationYear; }
        set
        {
            int currentYear = DateTime.Now.Year;
            if (value > currentYear) throw new ArgumentException("Publication year passes current year");
            else if (value < 0) throw new ArgumentException("Publication year can not be negative");
            else _publicationYear = value;
        }
    }
    public bool CanBorrow { get; set; }

    public Book(string title, string author, int year)
    {
        _isbn = Guid.NewGuid();
        Title = title;
        Author = author;
        PublicationYear = year;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Book info: title: {this.Title}, author: {this.Author}, published in: {this.PublicationYear}.");
    }
}