using Microsoft.EntityFrameworkCore;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Models;
using Timer.Core.Settings;
using Timer.Data.Context;

namespace Timer.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppSettings _appSettings;
    private readonly ApplicationDbContext _dbContext;

    public UsuarioRepository(AppSettings appSettings, ApplicationDbContext dbContext)
    {
        _appSettings = appSettings;
        _dbContext = dbContext;
    }

//     public async Task<Usuario> GetLoginAsync(string nome, string senha)
//     {
//         return await _dbContext.Usuarios
//             .AsNoTracking() // É bom usar AsNoTracking se você não pretende modificar os objetos retornados nesta consulta.
//             .Where(x => x.Nome.ToUpper() == nome.ToUpper() && x.Senha == senha) // Usando o parâmetro `senha` corretamente.
//             .Select(x => new Usuario
//             {
//                 Id = x.Id,
//                 Nome = x.Nome,
//                 Senha = x.Senha
//             })
//             .FirstOrDefaultAsync(); // Corrigido o método e removido o ToList().
//     }
}
