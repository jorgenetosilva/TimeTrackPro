using Microsoft.EntityFrameworkCore;
using Timer.Core.Models;
using System.Reflection;

namespace Timer.Data.Context;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
  {
  }

  public DbSet<Atividade> Atividades { get; set; }
  public DbSet<Categoria> Categorias { get; set; }
  public DbSet<EmpresaDetalhes> EmpresaDetalhes { get; set; }
  public DbSet<RegistroTempo> RegistrosTempo { get; set; }
  public DbSet<Usuario> Usuarios { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}

