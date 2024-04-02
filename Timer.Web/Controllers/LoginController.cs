using Microsoft.AspNetCore.Mvc;

namespace Timer.Web.Controllers;

public class LoginController : Controller
{
    [HttpGet("Login")]
    public IActionResult Index()
    {
        ViewData["ShowSidebar"] = false;
        return View("Index", "Home");
    }
}

// public class LoginController : Controller
// {
//     [HttpPost]
//     public async Task<IActionResult> Login(LoginViewModel model)
//     {
//         // ... Sua lógica de autenticação ...

//         if (/* autenticação bem-sucedida */)
//         {
//             return RedirectToAction("Index", "Home");
//         }
//         else
//         {
//             // Se a autenticação falhar, fique na página de login.
//             return View(model);
//         }
//     }
// }
