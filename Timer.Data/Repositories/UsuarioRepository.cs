using Microsoft.EntityFrameworkCore;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Models;
using Timer.Data.Context;

namespace Timer.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ApplicationDbContext _context;

    public UsuarioRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Usuario>> GetAllAsync()
    {
        return await _context.Usuarios.ToListAsync();
    }
}
