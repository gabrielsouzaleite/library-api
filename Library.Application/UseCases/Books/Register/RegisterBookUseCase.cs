using Library.Communication.Requests;
using Library.Communication.Response;

namespace Library.Application.UseCases.Books.Register;

public class RegisterBookUseCase
{
    public ResponseRegisterBookJson Execute(RequestBookJson request)
    {
        return new ResponseRegisterBookJson
        {
            Id = request.Id,
            Title = request.Title,
        };
    }
}
