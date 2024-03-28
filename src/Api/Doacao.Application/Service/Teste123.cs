using Doacao.Domain.Entidade;
using Doacao.Domain.Interface.Application;
using Doacao.Domain.Interface.Persistence;

namespace Doacao.Application.Service;

public class Teste123 : ITeste123
{
    private readonly ICompraInteligenteConfiguracaoRepository _compraInteligenteConfiguracaoRepository;
    public Teste123(ICompraInteligenteConfiguracaoRepository compraInteligenteConfiguracaoRepository)
    {
        _compraInteligenteConfiguracaoRepository = compraInteligenteConfiguracaoRepository;
    }

    public CompraInteligenteConfiguracao Teste1234()
    {
        return _compraInteligenteConfiguracaoRepository.teste123();
    }
}
