using Microsoft.AspNetCore.Mvc;

namespace Timer.Web.Controllers;

[Route("registro-tempo")]
public class RegistroTempoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
