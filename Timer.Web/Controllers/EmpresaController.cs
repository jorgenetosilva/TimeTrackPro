using Microsoft.AspNetCore.Mvc;
using Timer.Core.Interfaces.Repositories;

namespace Timer.Web.Controllers;

[Route("empresa")]
public class EmpresaController : Controller
{
    private readonly IEmpresaRepository _empresaRepository;

    // public EmpresaController(IEmpresaRepository empresaRepository)
    // {
    //     _empresaRepository = empresaRepository;
    // }

    [HttpGet]
    public IActionResult Index() => View();

    // [HttpGet("buscar")]
    // public async Task<IActionResult> GetFiliaisAsync(string nome, string cidade)
    // {
    //     var empresas = await _empresaRepository.GetComEnderecoAsync(nome, cidade);
    //     return View("_Grid", empresas);
    // }
}