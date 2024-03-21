using Timer.Core.Interfaces.Repositories;
using Timer.Core.Settings;
using Timer.Data.Context;
using Timer.Data.Repositories;

namespace Timer.Web.Configurations;

public static class DependencyInjection
{
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddSingleton(appSettings);
        services.AddScoped<ApplicationDbContext>();

        // services.AddSingleton<ILogWriter, LogWriter>();
        // services.AddScoped<INotification, Notification>();
        // services.AddScoped<IEmailHandler, EmailHandler>();

        // services.AddJobs();
        services.AddRepositories();
        // services.AddServices();

        // services.AddModelType<ILinha>();
        // services.AddModelType<ILinhaCrednet>();
    }
    public static void AddRepositories(this IServiceCollection services)
    {
        // services.AddScoped<ICarteiraRepository, CarteiraRepository>();
        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
    }

    // public static void AddServices(this IServiceCollection services)
    // {
    //     services.AddScoped<IContatoService, ContatoService>();
    // }

    // public static void AddModelType<T>(this IServiceCollection services)
    // {
    //     var type = typeof(T);
    //     var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes());
    //     var implamentations = types.Where(x => x.GetInterfaces().Contains(type));

    //     foreach (var implementation in implamentations)
    //         services.AddScoped(typeof(T), implementation);
    // }
}
