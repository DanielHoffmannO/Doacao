using Doacao.Domain.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Doacao.Domain.Interface.Persistence;

public interface ICompraInteligenteConfiguracaoRepository : IRepository<CompraInteligenteConfiguracao, short>
{
    CompraInteligenteConfiguracao teste123();
}
