using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

public class BaseDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public BaseDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Assegure-se de que o nome da sua string de conexão corresponde ao que está no seu arquivo appsettings.json
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString, options =>
        {
            options.MaxBatchSize(100); // Opcional: ajuste conforme sua necessidade
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery); // Opcional: melhora a performance para queries complexas
        });

        // Desabilita o tracking global para melhorar a performance, a menos que explicitamente solicitado
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define o comportamento de delete para evitar exclusão em cascata indesejada
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.NoAction;
        }

        // Aplica todas as configurações de entidade encontradas no assembly atual
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
