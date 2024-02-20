using SuperSite0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperSite0.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Show(int id)
        {

            var model = new BookShowInfo();

            using (var db = new BookDB())
            {
               // model.Book = db.Books.OrderBy(x => x.Title).Select(x => new BookInfo {Id = x.Id, Title = x.Title, Path = x.Title, AuthorId = x.AuthorId, Date = x.Date, GenreId = x.GenreId, Price = x.Price}).ToList();
               // model.Tags = db.Articles.Select(x => new FullArticleInfo { Id = x.Id, Announce = x.Announce, Body = x.Body, PubDate = x.PubDate, Title = x.Title }).FirstOrDefault(x => x.Id == id);
                
            }
            return View(model);
            
        }
    }
}