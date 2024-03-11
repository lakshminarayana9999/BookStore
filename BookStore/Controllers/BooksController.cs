using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Services;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly BookService _bookService;

        public BooksController(BookService bkService)
        {
            _bookService = bkService;
        }

        [HttpGet("sorted-by-publisher")]
        public IActionResult GetBooksSortedByPublisher()
        {
            var sortedBooks = _bookService.GetBooksSortedByPublisher();
            return Ok(sortedBooks);
        }

        [HttpGet("sorted-by-author-first-name")]
        public IActionResult GetBooksSortedByAuthorFirstName()
        {
            var sortedBooks = _bookService.GetBooksSortedByAuthorFirstName();
            return Ok(sortedBooks);
        }


        [HttpGet("sorted-by-author-last-name")]
        public IActionResult GetBooksSortedByAuthorLastName()
        {
            var sortedBooks = _bookService.GetBooksSortedByAuthorLastName();
            return Ok(sortedBooks);
        }



        [HttpGet("sorted-by-title")]
        public IActionResult GetBooksSortedByTitle()
        {
            var sortedBooks = _bookService.GetBooksSortedByTitle();
            return Ok(sortedBooks);
        }

        [HttpGet("total-price")]
        public IActionResult GetTotalPriceOfBooks()
        {
            var totalPrice = _bookService.GetTotalPriceOfBooks();
            return Ok(totalPrice);
        }

        [HttpPost("create")]
        public IActionResult CreateBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest("Book data is null");
            }

            _bookService.AddBook(book);

            return Ok(book);
        }

       
    }
}
