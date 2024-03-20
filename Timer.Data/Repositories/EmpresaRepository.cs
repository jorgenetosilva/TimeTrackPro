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

    public async Task<IEnumerable<Empresa>> GetAsync()
    {
        return await _dbContext.Empresas
            .Select(x => new Empresa
            {
                Id = x.Id,
                Nome = x.Nome
            })
            .ToListAsync();
    }
}
