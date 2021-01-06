using LibraryManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagerSystem.Controllers
{
    public class HomeController : Controller
    {
        private nitlibraryEntities db = new nitlibraryEntities();

        public ActionResult Index(string bookIdOrBookName)
        {

            if (string.IsNullOrEmpty(bookIdOrBookName))
            {
                var book = (from s in db.books select s).ToList();
                return View("Index", book);
            }

            var books = db.books
                .Where(x => x.book_id.Contains(bookIdOrBookName) || x.bname.Contains(bookIdOrBookName))
                .ToList();

            return View(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}