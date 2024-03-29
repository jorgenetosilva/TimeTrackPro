using Timer.Core.Models;

namespace Timer.Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}