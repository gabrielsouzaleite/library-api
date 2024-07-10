using Library.Communication.Response;

namespace Library.Application.UseCases.Books.GetAll;

public class GetAllBooksUseCase
{
    public ResponseAllBooksJson Execute()
    {
        return new ResponseAllBooksJson
        {
            Books = new List<ResponseShortBooksJson>
            {
                new ResponseShortBooksJson
                {
                    Id = 1,
                    Title = "The Little Prince",
                    Author = "Antoine de Saint-Exupéry",
                    Price = 10.0m,
                    Gender = Communication.Enums.BookType.romance
                }
            }
        };
    }
}
