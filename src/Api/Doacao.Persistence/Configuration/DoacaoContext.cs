using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CompraInteligente.Persistence.Context;

public class DoacaoContext : AbstractContext
{
    public DoacaoContext(DbContextOptions<DoacaoContext> options) : base(options) { }

    protected override Assembly GetConfigurationAssembly()
        => GetType().Assembly;

    protected override Func<Type, bool> GetConfigurationTypePredicate()
        => type => type.Namespace != null && type.Namespace.EndsWith("Mappings.Doacao");
}
