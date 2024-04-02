using Microsoft.AspNetCore.Mvc;

namespace Timer.Web.Controllers;

[Route("registro-tempo")]
public class RegistroTempoController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();
}
