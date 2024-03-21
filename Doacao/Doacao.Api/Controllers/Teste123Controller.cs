using Doacao.Domain.Interface.Application;
using Microsoft.AspNetCore.Mvc;

namespace Doacao.Api.Controllers;


[ApiController]
[Route("[controller]")]
public class Teste123Controller : ControllerBase
{
    public readonly ITeste123 _teste123;
    public Teste123Controller(ITeste123 teste123)
    {
        _teste123 = teste123;
    }

    [HttpGet]
    public IActionResult teste1234()
    {
        return Ok(_teste123.Teste1234());
    }
}
