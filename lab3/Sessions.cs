public class SessionController : Controller
{
    public IActionResult SetSession()
    {
        HttpContext.Session.SetString("MySessionKey", "Hello, ASP.NET Core!");

        return View();
    }

    public IActionResult GetSession()
    {
        string sessionValue = HttpContext.Session.GetString("MySessionKey");

        return Content($"Session Value: {sessionValue}");
    }
}
