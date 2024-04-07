using Microsoft.AspNetCore.Mvc;
using Timer.Core.Interfaces.Helpers;
using Timer.Core.Interfaces.Repositories;
// using Timer.Core.Extensions;
using Timer.Core.Settings;
using Timer.Web.ViewModels.Login;
using Timer.Core.Models;
using Timer.Web.Configurations.Extensions;

namespace Timer.Web.Controllers;

public class LoginController : Controller
{
    // private readonly AppSettings _appSettings;
    // private readonly INotification _notification;
    // private readonly IUsuarioRepository _usuarioRepository;
    // public LoginController(AppSettings appSettings, INotification notification, IUsuarioRepository usuarioRepository)
    // {
    //     _appSettings = appSettings;
    //     _notification = notification;
    //     _usuarioRepository = usuarioRepository;
    // }

    [HttpGet, Route("login")]
    public IActionResult Index()
    {
        ViewData["ShowSidebar"] = false;
        return View("Index", "Home");
    }

    // [HttpPost, Route("login")]
    // public async Task<ActionResult> Index(LoginViewModel model)
    // {
    //     if (!model.IsValid(_notification))
    //         return BadRequest(_notification.GetAsString());

    //     var usuario = await _usuarioRepository.GetLoginAsync(model.Usuario, model.Senha.ToSha256Hash());
    //     if (usuario == null)
    //     {
    //         TempData["ErrorMessage"] = "Usuário e/ou senha inválidos";
    //         return RedirectToAction(nameof(Index));
    //     }

    //     HttpContext.LogIn(new UsuarioCookie
    //     {
    //         Codigo = Convert.ToInt32(usuario.Id),
    //         Nome = usuario.Nome,
    //     });

    //     return RedirectToAction("Index", "Home");
    // }
}


