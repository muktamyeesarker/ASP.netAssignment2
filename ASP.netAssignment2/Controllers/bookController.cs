using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    //[ApiController]
   // [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        [Route("/Book")]
        public IActionResult GetAllBooks()
        {
            return Ok("Get all books");
        }

        [HttpGet]
        [Route("/Book/{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok($"Book ID: {id}");
        }

        [HttpPost]
        
        public IActionResult AddBook(Book book)
        {
            return Ok("Added a new book");
        }

        [HttpPut]
        [Route("/Book/{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            return Ok($"Updated book with ID: {id}");
        }

        [HttpDelete]
        [Route("/Book/{id}")]
        public IActionResult DeleteBook(int id)
        {
            return Ok($"Deleted book with ID: {id}");
        }
    }
}

