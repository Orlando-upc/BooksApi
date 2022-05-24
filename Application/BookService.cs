
using Application.Dto.BookDto;
using Domain;
using Infrastructure;

namespace Application
{
    public class BookService
    {
        private readonly BookDbContext _bookDbContext;

        public BookService(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }

        public CreateBookDto Create(Book book)
        {
            _bookDbContext.Book.Add(book);
            _bookDbContext.SaveChanges();
            return new CreateBookDto()
            {
                Id = book.Id,
                Author = book.Author,
                Title = book.Title,
                Genre = book.Genre,
                Price = book.Price,
                Publisher = book.Publisher
            };
        }
        public void Update(UpdateBookRequest request)
        {

            var book = _bookDbContext.Book.Find(request.Id);
            _ = book ?? throw new ApplicationException("El id no existe en la base de datos");   
            book.Update(request.Title, request.Author, request.Publisher, request.Genre, request.Price);
            _bookDbContext.Book.Update(book);
            _bookDbContext.SaveChanges();

        }
        public void Delete(int id)
        {
            var book = _bookDbContext.Book.Find(id);
            _bookDbContext.Book.Remove(book);
            _bookDbContext.SaveChanges();
        }

        public List<Book> Get()
        {
           return _bookDbContext.Book.ToList();
        }
    }
}
