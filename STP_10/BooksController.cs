using STP_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace STP_10
{
    public class BooksController : ApiController
    {
        static List<Book> books = Book.BooksDB();

        [HttpGet]
        public IHttpActionResult Get()
        {
            if (books.Count == 0)
                return StatusCode(HttpStatusCode.NoContent);

            return Json(books);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            Book book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();

            return Json(book);
        }
    }
}