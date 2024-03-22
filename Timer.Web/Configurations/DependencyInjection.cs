using Microsoft.EntityFrameworkCore;
using Timer.Core.Interfaces.Repositories;
using Timer.Core.Settings;
using Timer.Data.Context;
using Timer.Data.Repositories;

namespace Timer.Web.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Timer.Data")
            ));

        services.AddScoped<IEmpresaRepository, EmpresaRepository>();

        // Adicione outras dependências conforme necessário

        return services;
    }
}
