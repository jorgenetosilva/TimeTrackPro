using Microsoft.AspNetCore.Mvc;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Models;

namespace Timer.Web.Controllers;

[Route("empresa")]
public class EmpresaController : Controller
{
    private readonly IEmpresaRepository _empresaRepository;

    public EmpresaController(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    [HttpGet]
    public IActionResult Index() => View();

    [HttpGet("buscar")]
    public async Task<IActionResult> GetAsync(string empresa, string cidade)
    {
        var empresas = await _empresaRepository.GetEmpresasAsync(empresa, cidade);
        return View("_Grid", empresas);
    }
    
    [HttpGet("cadastrar")]
    public IActionResult GetCadastrarAsync()
    {
        return View("Form");
    }

    [HttpPost("cadastrar")]
    public async Task<IActionResult> CadastrarAsync(EmpresaDetalhes empresa)
    {
        empresa.Status ??= 0;
        await _empresaRepository.AddAsync(empresa);
        return RedirectToAction("Index");
    }
}
