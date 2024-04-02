using Microsoft.AspNetCore.Mvc;

namespace Timer.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Verifica se o usuário está autenticado
        // if (User.Identity.IsAuthenticated)
        {
            // Usuário autenticado, pode acessar a página Home
            // return View("Index", "Home");
        }

        // Usuário não autenticado, redirecionar para a tela de Login
        return RedirectToAction("Index", "Login"); // Ajuste o "Account" para o nome do seu controlador de login
    }
}
