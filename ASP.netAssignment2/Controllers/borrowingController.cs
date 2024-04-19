using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class BorrowingController : ControllerBase
    {
        [HttpGet]
        [Route("/Borrowing book")]
        public IActionResult GetAllBorrowingBooks()
        {
            return Ok("Get all borrowing books from readers");
        }

        [HttpGet]
        [Route("/Borrowing book/{id}")]
        public IActionResult GetBorrowingBookById(int id)
        {
            return Ok($"Borrowing book ID: {id}");
        }

        [HttpPost]
        
        public IActionResult BorrowBook(Borrowing borrowing)
        {
            return Ok("Borrowed a new book");
        }

        [HttpPut]
        [Route("/Borrowing book/{id}")]
        public IActionResult UpdateBorrowingBook(int id, Borrowing borrowing)
        {
            return Ok($"Updated borrowing book with ID: {id}");
        }

        [HttpDelete]
        [Route("/Borrowing book/{id}")]
        public IActionResult ReturnBorrowingBook(int id)
        {
            return Ok($"Returned borrowing book with ID: {id}");
        }
    }
}
