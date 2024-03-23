using Microsoft.EntityFrameworkCore;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Models;
using Timer.Data.Context;

namespace Timer.Data.Repositories;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmpresaRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<EmpresaDetalhes>> GetEmpresasAsync(string nome = null, string cidade = null)
    {
        var query = _dbContext.EmpresaDetalhes.AsQueryable();

        if (!string.IsNullOrEmpty(nome))
            query = query.Where(x => EF.Functions.Like(x.Empresa, $"%{nome}%"));

        if (!string.IsNullOrEmpty(cidade))
            query = query.Where(x => EF.Functions.Like(x.Cidade, $"%{cidade}%"));

        return await query.Select(x => new EmpresaDetalhes
        {
            EmpresaId = x.EmpresaId,
            Empresa = x.Empresa,
            Cidade = x.Cidade,
            Endereco = x.Endereco,
            Cep = x.Cep,
            Bairro = x.Bairro,
            Estado = x.Estado,
            Complemento = x.Complemento,
            // Status = x.Status
        })
        .ToListAsync();
    }
}
