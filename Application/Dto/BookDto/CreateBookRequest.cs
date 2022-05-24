

using Domain;

namespace Application.Dto.BookDto;

public class CreateBookRequest
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }

    public Book GetBook()
    {
        return new Book()
        {
            Author = Author,
            Title = Title,
            Genre = Genre,
            Price = Price,
            Publisher = Publisher
        };
    }

}
public class CreateBookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }
}

        

