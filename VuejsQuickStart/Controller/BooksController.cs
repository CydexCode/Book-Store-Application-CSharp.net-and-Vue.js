using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VuejsQuickStart.DataAccess.Models;
using VuejsQuickStart.DataAccess;

namespace VuejsQuickStart.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookContext _dbContext;
        public BooksController(BookContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IActionResult Get()
        {
            //var books = new List<Book>() { 
            //new Book(){ID = 1 , Name="David", Title="david book"},
            //new Book(){ID = 2 , Name="John", Title="John book"}
            //};
            var books = _dbContext.Books.ToList();
            return Ok(books);
        }
        [Route("Create")]
        [HttpPost]
        public IActionResult Create(Book model)
        {
            var result = _dbContext.Books.Add(model);
            _dbContext.SaveChanges();
            var books = _dbContext.Books.ToList();
            return Ok(books);
        }
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Book model)
        {

            var book = _dbContext.Books.Where(x=>x.ID==model.ID).FirstOrDefault();
            book.Name = model.Name;
            book.Title = model.Title;
            _dbContext.SaveChanges();
            var books = _dbContext.Books.ToList();
            return Ok(books);
        }
        [Route("Delete")]
        [HttpPost]
        public IActionResult Delete(int? id)
        {

            var book = _dbContext.Books.Where(x => x.ID == id).FirstOrDefault();
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
            var books = _dbContext.Books.ToList();
            return Ok(books);
        }
    }
}
