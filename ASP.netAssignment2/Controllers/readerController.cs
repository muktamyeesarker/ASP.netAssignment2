using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class ReaderController : ControllerBase
    {
        [HttpGet]
        [Route("/Reader")]
        public IActionResult GetAllReaders()
        {
            return Ok("Get all readers");
        }

        [HttpGet]
        [Route("/Reader/{id}")]
        public IActionResult GetReaderById(int id)
        {
            return Ok($"Reader ID: {id}");
        }

        [HttpPost]
        
        public IActionResult AddReader(Reader reader)
        {
            return Ok("Added a new reader");
        }

        [HttpPut]
        [Route("/Reader/{id}")]
        public IActionResult UpdateReader(int id, Reader reader)
        {
            return Ok($"Updated reader with ID: {id}");
        }

        [HttpDelete]
        [Route("/Reader/{id}")]
        public IActionResult DeleteReader(int id)
        {
            return Ok($"Deleted reader with ID: {id}");
        }
    }
}

