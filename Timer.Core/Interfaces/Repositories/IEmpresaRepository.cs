using Timer.Core.Models;

namespace Timer.Core.Interfaces.Repositories;

public interface IEmpresaRepository
{
    Task<IEnumerable<EmpresaDetalhes>> GetEmpresasAsync(string Nome = null, string Cidade = null);
    Task AddAsync(EmpresaDetalhes empresa);
    Task EditarIdAsync(EmpresaDetalhes empresa);
       Task<EmpresaDetalhes> BuscarPorIdAsync(int id);
}
