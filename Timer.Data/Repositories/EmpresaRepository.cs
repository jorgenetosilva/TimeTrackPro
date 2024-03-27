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
            Status = x.Status
        })
        .ToListAsync();
    }

    public async Task<EmpresaDetalhes> BuscarPorIdAsync(int id)
    {
        return await _dbContext.EmpresaDetalhes
            .Where(x => x.EmpresaId == id)
            .Select(x => new EmpresaDetalhes
            {
                EmpresaId = x.EmpresaId,
                Empresa = x.Empresa,
                Cidade = x.Cidade,
                Endereco = x.Endereco,
                Cep = x.Cep,
                Status = x.Status,
                Bairro = x.Bairro,
                Estado = x.Estado,
                Complemento = x.Complemento,
            })
        .FirstOrDefaultAsync(x => x.EmpresaId == id);
    }

    public async Task AddAsync(EmpresaDetalhes empresa)
    {
        empresa.EmpresaId = await _dbContext.EmpresaDetalhes.MaxAsync(x => x.EmpresaId) + 1;
        await _dbContext.EmpresaDetalhes.AddAsync(empresa);
        await _dbContext.SaveChangesAsync();
    }

    public async Task EditarIdAsync(EmpresaDetalhes empresa)
    {
        _dbContext.EmpresaDetalhes.Update(empresa);
        await _dbContext.SaveChangesAsync();
    }
}
