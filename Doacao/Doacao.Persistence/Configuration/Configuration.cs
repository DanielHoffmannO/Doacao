
using CompraInteligente.Persistence.Context;
using Doacao.Domain.Interface;
using Doacao.Persistence.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        => services.AddScoped<ICompraInteligenteConfiguracaoRepository, CompraInteligenteConfiguracaoRepository>();

    public static IServiceCollection RegisterPersistence(this IServiceCollection services, IConfiguration configuration) =>
    services.AddDbContext<DoacaoContext>(options =>
    {
        options.UseSqlServer(configuration.GetConnectionString("DoacaoConnection"));
#if DEBUG
        var loggerFactory = new LoggerFactory().AddSerilog(Log.Logger);
        options.UseLoggerFactory(loggerFactory);
        options.EnableDetailedErrors();
        options.EnableSensitiveDataLogging();
#endif
    }).RegisterRepositories();
}
