﻿using Library.Communication.Enums;

namespace Library.Communication.Response;

public class ResponseShortBooksJson
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public BookType Gender { get; set; }

    public decimal Price { get; set; }

}
