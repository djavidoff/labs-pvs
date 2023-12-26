using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class BookController : Controller
{
    private static List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Title = "ASP.NET Core in Action", Author = "Andrew Lock" },
        new Book { Id = 2, Title = "C# in Depth", Author = "Jon Skeet" },
        new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma" }
    };

    public IActionResult Index()
    {
        return View(_books);
    }

    public IActionResult Details(int id)
    {
        var book = _books.Find(b => b.Id == id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
}
