using System;
using Books;

internal class Program
{
    private static void Main()
    {
        // Book book1 = new Book("title", "author", 2000, true);
        // Console.WriteLine(book1.Title);
        // Guid guid1 = Guid.NewGuid();
        // Guid guid2 = Guid.NewGuid();
        // Console.WriteLine(guid1.ToString());
        // Console.WriteLine(guid2.ToString());
        Comic comic1 = new Comic("Conan", "Aoyama", 1997);
        comic1.AddArtist("hihi");
        comic1.AddArtist("hihi");
        comic1.AddArtist("haha");
        Console.WriteLine(comic1.GetAllArtits());
        comic1.RemoveArtist("haha");
        Console.WriteLine(comic1.GetAllArtits());
        comic1.RemoveArtist("hoho");
    }
}
