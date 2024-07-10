using Library.Application.UseCases.Books.Delete;
using Library.Application.UseCases.Books.GetAll;
using Library.Application.UseCases.Books.Register;
using Library.Application.UseCases.Books.Update;
using Library.Communication.Requests;
using Library.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers;

public class LibraryController : MyBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestBookJson request)
    {
        var useCase = new RegisterBookUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllBooksJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllBooksUseCase();

        var response = useCase.Execute();

        if (response.Books.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestBookJson request)
    {
        var useCase = new UpdateBookUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteBookByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }

}
