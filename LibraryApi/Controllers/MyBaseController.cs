using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers;

[Route("library-api/[controller]")]
[ApiController]
public abstract class MyBaseController : ControllerBase
{
}
