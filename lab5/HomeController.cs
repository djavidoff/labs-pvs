public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("about/{id}")]
    public IActionResult About(int id)
    {
        return Content($"About Page with ID: {id}");
    }
}
