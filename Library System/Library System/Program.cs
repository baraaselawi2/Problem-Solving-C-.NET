var books = new List<Book>
{
    new Book { Pages = 200, Title = "Book One", Author = "Author A" },
    new Book { Pages = 350, Title = "Book Two", Author = "Author B" },
    new Book { Pages = 150, Title = "Book Three", Author = "Author C" },
    new Book { Pages = 400, Title = "Book Four", Author = "Author D" }
};

Func<Book, bool> func = book => book.Pages > 300;
Action<Book> action = book => Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
books.Where(func)
    .ToList()
    .ForEach(action);




public class Book
{
    public int Pages { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}