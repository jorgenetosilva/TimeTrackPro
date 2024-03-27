using Microsoft.AspNetCore.Mvc;

namespace Timer.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

