namespace Books;
using Interface;

class TextBook : Book, ITextBook
{
    private int _pagesNumber;

    public int[] Pages { get; set; }
    public int PagesNumber 
    {
        get { return _pagesNumber; }
        set
        {
            if (value <= 0) throw new ArgumentException("Number of pages can not be negative");
            else _pagesNumber = value;
        }
    }

    public TextBook(string title, string author, int year, int pages, bool canBorrow = true) : base(title, author, year)
    {
        Title = title;
        Author = author;
        PublicationYear = year;
        PagesNumber = pages;
        CanBorrow = canBorrow;
        Pages = new int[_pagesNumber];
    }

    public int[] PrintPages(int start, int end)
    {
        if (start > Pages.Count() || end > Pages.Count()) throw new ArgumentOutOfRangeException("Can not print pages exceeding the books\'s pages");
        else if (start <= 0 || end <= 0) throw new ArgumentException("Start & end pages can not be negative");
        else if (end < start) throw new ArgumentException("End page can not be less than start page");
        else 
        {
            Console.WriteLine($"Printing from page {start} to {end}");
            int length = end - start + 1;
            int[] result = new int[length];
            Array.Copy(Pages, start - 1, result, 0, length);
            return result;
        }
    }
}