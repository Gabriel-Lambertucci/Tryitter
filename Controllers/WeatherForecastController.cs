using Microsoft.AspNetCore.Mvc;

namespace Tryitter.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{

    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "cadastrar")]
    public ActionResult PostCadastrar()
    {
        return Ok();
    }
}
