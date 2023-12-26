using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var users = _context.Users.ToList();

        return View(users);
    }

    public IActionResult Details(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);

        return View(user);
    }

    public IActionResult Create()
    {
        var newUser = new User
        {
            Username = "NewUser",
            Email = "newuser@example.com",
            Password = "password123"
        };

        _context.Users.Add(newUser);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
