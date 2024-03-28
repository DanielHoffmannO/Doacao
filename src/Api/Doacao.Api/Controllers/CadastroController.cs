using Doacao.Domain.Interface.Application;
using Microsoft.AspNetCore.Mvc;

namespace Doacao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CadastroController : ControllerBase
{
    public CadastroController(ITeste123 teste123)
    {
        _teste123 = teste123;
    }

    [HttpGet]
    public IActionResult teste1234()
    {
        return Ok(_teste123.Teste1234());
    }
}
