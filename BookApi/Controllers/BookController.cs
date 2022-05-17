using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }
    }
}
