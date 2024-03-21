using Timer.Core.Models;

namespace Timer.Core.Interfaces.Repositories;

public interface IEmpresaRepository
{
    Task<IEnumerable<EmpresaDetalhes>> GetEmpresasAsync(string Nome = null, string Cidade = null);
}
