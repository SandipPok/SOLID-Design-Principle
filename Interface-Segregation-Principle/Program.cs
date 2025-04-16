public class Program
{
    public static void Main()
    {
        Console.WriteLine("Librarian:");
        Librarian librarian = new Librarian();
        Book book = new Book()
        {
            BookId = "Book-2002",
            Title = "SOLID Principle using C#",
            Author = "No One"
        };
        librarian.AddBook(book);
        librarian.BorrowBook(book.BookId);
        librarian.SearchCatalog("SOLID");
        librarian.ReturnBook(book.BookId);
        librarian.RemoveBook(book.BookId);
        Console.WriteLine("\nMember:");
        Member member = new Member();
        //member.AddBook(book); //Compile Time Error
        member.BorrowBook(book.BookId);
        member.SearchCatalog("SOLID");
        member.ReturnBook(book.BookId);
        //member.RemoveBook(book.BookId); //Compile Time Error
        Console.WriteLine("\nMember:");
        Guest guest = new Guest();
        //guest.AddBook(book); //Compile Time Error
        //guest.BorrowBook(book.BookId); //Compile Time Error
        guest.SearchCatalog("SOLID");
        //guest.ReturnBook(book.BookId); //Compile Time Error
        //guest.RemoveBook(book.BookId); //Compile Time Error
        Console.ReadKey();
    }
}

public class Book
{
    public string BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public override string ToString()
    {
        return $"[BookId: {BookId}, Title: {Title}, Author:{Author}]";
    }
}

public interface IBorrowReturn
{
    void BorrowBook(string bookId);
    void ReturnBook(string bookId);
}
public interface ISearchable
{
    void SearchCatalog(string searchTerm);
}
public interface IManageInventory
{
    void AddBook(Book book);
    void RemoveBook(string bookId);
}

public class Member : IBorrowReturn, ISearchable
{
    public void BorrowBook(string bookId)
    {
        // Implementation to borrow a book.
        Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
    }
    public void ReturnBook(string bookId)
    {
        // Implementation to return a book.
        Console.WriteLine($"Member Return Book, BookId: {bookId}");
    }
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
        Console.WriteLine($"Member Search Book, Search Catalog: {searchTerm}");
    }
}
public class Librarian : IBorrowReturn, ISearchable, IManageInventory
{
    public void BorrowBook(string bookId)
    {
        // Implementation to borrow a book.
        Console.WriteLine($"Librarian Borrow Book, BookId: {bookId}");
    }
    public void ReturnBook(string bookId)
    {
        // Implementation to return a book.
        Console.WriteLine($"Librarian Return Book, BookId: {bookId}");
    }
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
        Console.WriteLine($"Librarian Search Book, Search Catalog: {searchTerm}");
    }
    public void AddBook(Book book)
    {
        // Implementation to add a book.
        Console.WriteLine($"Librarian Add Book, {book}");
    }
    public void RemoveBook(string bookId)
    {
        // Implementation to remove a book.
        Console.WriteLine($"Librarian Remove Book, BookId: {bookId}");
    }
}

public class Guest : ISearchable
{
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
        Console.WriteLine($"Guest Search Book, Search Catalog: {searchTerm}");
    }
}