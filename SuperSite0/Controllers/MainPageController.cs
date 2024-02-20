using SuperSite0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperSite0.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Show(string id)
        {
            MainPageShowInfo model = new MainPageShowInfo();
            using (var db = new BookDB())
            {
                // :TODO: 
                // 1. Логотип должен возвращать на главную страницу 
                // 2. Добавить дату публикации каждой статьи в вёрстку 
                // 3. Сделать страницу новости


                model.Genres = db.Genres.OrderBy(x => x.Title).Select(x => new GenreInfo { Title = x.Title, Path = x.Title }).ToList();
                model.Tags = db.Tags.OrderBy(x => x.Title).Select(x => new TagInfo { Title = x.Title, Path = x.Title }).ToList();
                IQueryable<Book> query = db.Books;
                if (id != null)
                {
                    query = query.Where(x => x.Genre.Title == id);
                }
                model.Books = query.OrderByDescending(x => x.Date).Take(10).Select(x => new BookInfo { Id = x.Id, Title = x.Title, Price = x.Price, Date = x.Date, AuthorId = x.AuthorId, GenreId = x.GenreId }).ToList();

                return View(model);
            }
        }
    }
}