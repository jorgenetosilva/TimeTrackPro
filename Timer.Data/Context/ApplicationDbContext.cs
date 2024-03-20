using Microsoft.EntityFrameworkCore;
using Timer.Core.Models;
using Timer.Core.Settings;

namespace Timer.Data.Context;

public class ApplicationDbContext : BaseDbContext
{
  public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
  {
  }
  public DbSet<Cidade> Cidades { get; set; }
  public DbSet<EmpresaEndereco> EmpresaEnderecos { get; set; }
  public DbSet<Categoria> Categorias { get; set; }
  public DbSet<Usuario> Usuarios { get; set; }
  public DbSet<Atividade> Atividades { get; set; }
  public DbSet<RegistroTempo> RegistrosTempo { get; set; }
  public DbSet<Empresa> Empresas { get; set; }

}
