public class CookieController : Controller
{
    public IActionResult SetCookie()
    {
        Response.Cookies.Append("MyCookie", "Hello, ASP.NET Core!");

        return View();
    }

    public IActionResult GetCookie()
    {
        string cookieValue = Request.Cookies["MyCookie"];

        return Content($"Cookie Value: {cookieValue}");
    }
}
