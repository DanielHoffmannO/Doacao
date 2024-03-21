using Doacao.Application.Service;
using Doacao.Domain.Interface.Application;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApplication(this IServiceCollection services)
        => services.AddScoped<ITeste123, Teste123>();
}
