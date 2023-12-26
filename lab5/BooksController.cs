[Route("api/[controller]")]
public class BooksController : Controller
{
    [Route("[action]")]
    public IActionResult List()
    {
        return Content("List of books");
    }

    [Route("[action]/{id}")]
    public IActionResult Details(int id)
    {
        return Content($"Book details for ID: {id}");
    }
}
