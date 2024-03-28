using CompraInteligente.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Doacao.Domain.Entidade;
using Doacao.Domain.Interface.Persistence;

namespace Doacao.Persistence.Persistence.Repositories;

public class CompraInteligenteConfiguracaoRepository : Repository<CompraInteligenteConfiguracao, short>, ICompraInteligenteConfiguracaoRepository
{
    public CompraInteligenteConfiguracaoRepository(DoacaoContext context) : base(context)
    {
    }

    public CompraInteligenteConfiguracao teste123()
    {
        return DbSet.FirstOrDefault();
    }
}



