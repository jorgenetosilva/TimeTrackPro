using Microsoft.AspNetCore.Mvc;
using Timer.Core.Interfaces.Helpers;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Models;

namespace Timer.Web.Controllers;

[Route("empresa")]
public class EmpresaController : Controller
{
    private readonly IEmpresaRepository _empresaRepository;
    private readonly INotification _notification;

    public EmpresaController(IEmpresaRepository empresaRepository, INotification notification)
    {
        _empresaRepository = empresaRepository;
        _notification = notification;
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
    public async Task<IActionResult> CadastrarAsync(EmpresaDetalhes empresaDetalhes)
    {
        if (!empresaDetalhes.IsValid(_notification))
            return BadRequest(_notification.GetAsString());

        empresaDetalhes.Status ??= 0;
        await _empresaRepository.AddAsync(empresaDetalhes);
        return RedirectToAction("Index");
    }

    [HttpGet("editar/{id}")]
    public async Task<IActionResult> Editar(int id)
    {
        var empresa = await _empresaRepository.BuscarPorIdAsync(id);
        if (empresa == null)
            return NotFound();

        return View("Form", empresa);
    }

    [HttpPost("editar/{id}")]
    public async Task<IActionResult> EditarEmpresa(EmpresaDetalhes empresa)
    {
        empresa.Status ??= 0;
        if (empresa == null)
            return NotFound();

        await _empresaRepository.EditarIdAsync(empresa);
        return RedirectToAction("Index");
    }
}
