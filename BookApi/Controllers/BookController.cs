using Application;
using Application.Dto.BookDto;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookDbContext bookDbContext)
        {
            _bookService = new BookService(bookDbContext);
        }
        [HttpGet]
        public List<Book> Get()
        {
            return _bookService.Get();

        }

        [HttpPost]
        public ActionResult<CreateBookDto> Create(CreateBookRequest request)
        {
            var dto = _bookService.Create(request.GetBook());
            return Ok(dto);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(UpdateBookRequest request, int id)
        {

            if (request.Id != id)
            {
                return BadRequest("El id no coincide");
            }

            _bookService.Update(request);
            return Ok();
        } 

        [HttpDelete("{id:int}")]
        public IActionResult Delete(Book book, int id)
        {
            if (book.Id != id)
            {
                return BadRequest("El id no coincide");
            }
            _bookService.Delete(id);
            return Ok();
        }
    }
}
