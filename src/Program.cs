using System;
using Books;
using User;
using Libraries;

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
        Comic comic1 = new Comic("Detective Conan - Case Closed", "Gosho Aoyama", 1994);
        comic1.AddArtist("Juninchi Iioka");
        comic1.AddArtist("Katsuo Ono");
        comic1.AddArtist("Tetsu Kojima");
        Console.WriteLine(comic1.GetAllArtits());
        comic1.RemoveArtist("Tetsu Kojima");
        Console.WriteLine(comic1.GetAllArtits());
        comic1.PrintInfo();
        // comic1.RemoveArtist("hoho");
        Novel novel1 = new Novel("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        novel1.PrintInfo();
        novel1.AddGenre("Tragedy");
        novel1.PrintInfo();
        TextBook textbook1 = new TextBook("Math 1", "Math University", 1990, 50);
        Console.WriteLine(textbook1.PagesNumber);
        int[] test = textbook1.PrintPages(10, 20);
        Console.WriteLine(test.Count());
        ResearchPaper research1 = new ResearchPaper("Research 1", "Helsinki University", 2020, 20);
        int[] test1 = research1.PrintPages(1, 10);
        Console.WriteLine(test1.Count());
        Console.WriteLine(research1.CanBorrow);

        Customer cus1 = new Customer("Anna");
        Customer cus2 = new Customer("Bill");
        Console.WriteLine(cus1.Role);
        Librarian lib1 = new Librarian("Ben");
        Console.WriteLine(lib1.Role);

        Library library = new Library("Oodi");
        library.AddBook(comic1);
        library.AddBook(novel1);
        // library.GetBook(novel1);
        // library.SearchBookByTitle("The Great GATSBY");
        library.AddUser(cus1);
        library.AddUser(lib1);
        library.EditUser(cus1, "Anya");
        Console.WriteLine(cus1.Name);
        library.EditBook(comic1, null, null, null);
        comic1.PrintInfo();
        cus1.Borrow(comic1, library);
        // library.GetBook(comic1);
        cus1.Return(comic1, library);
        // library.GetBook(comic1);
        // cus2.Borrow(comic1, library);
        lib1.AddBookToLibrary(textbook1, library);
        lib1.AddBookToLibrary(research1, library);
        // library.GetAllBooks();
        // lib1.RemoveBookFromLibrary(research1, library);
        lib1.EditBookInLibrary(textbook1, library, null, null, 2000);
        textbook1.PrintInfo();
        cus1.Borrow(research1, library);
    }
}
