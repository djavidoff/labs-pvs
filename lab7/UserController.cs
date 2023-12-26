using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    [HttpPost]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }

        return View(user);
    }

    public IActionResult Success()
    {
        return View();
    }
}
