public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("about")]
    public IActionResult About()
    {
        return View();
    }
}
