using Microsoft.EntityFrameworkCore;
using Timer.Core.Models;
using Timer.Data.Context;

namespace Timer.Data.Repositories;

public class EmpresaRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmpresaRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // public async Task<IEnumerable<Empresa>> GetAsync()
    // {
    //     return await _dbContext.Empresas
    //         .Select(x => new Empresa
    //         {
    //             Id = x.Id,
    //             Nome = x.Nome
    //         })
    //         .ToListAsync();
    // }

    // public async Task<IEnumerable<Empresa>> GetComEnderecoAsync(string nome = null, string cidade = null)
    // {
    //     var query = _dbContext.Empresas.AsQueryable();

    //     if (!string.IsNullOrEmpty(nome))
    //         query = query.Where(x => EF.Functions.Like(x.Nome, $"%{nome}%"));

    //     if (!string.IsNullOrEmpty(cidade))
    //         query = query.Where(x => EF.Functions.Like(x.Cidade, $"%{cidade}%"));

    //     return await query.Select(x => new Empresa
    //     {
    //         Id = x.Id,
    //         Nome = x.Nome,
    //     })
    //     .ToListAsync();
    // }
}
