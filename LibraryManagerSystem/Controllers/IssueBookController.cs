using LibraryManagerSystem.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagerSystem.Controllers
{
    public class IssueBookController : Controller
    {
        nitlibraryEntities db = new nitlibraryEntities();

        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getcat()
        {
            var cats = db.categories.Select(p => new
            {
                ID = p.id,
                Cname = p.catname
            }).ToList();
            return Json(cats, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetIDCat(int cid)
        {
            var catid = (from s in db.books where s.cat_id == cid select s.cat_id).ToList();
            return Json(catid, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Getbook(int cid)
        {
            var books = db.books.Where(p => p.cat_id == cid).Select(p => new
            {
                ID = p.book_id,
                Bname = p.bname,
                Amount = p.amount
            }).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetIDBook(string bid)
        {
            var bookid = (from s in db.books where s.book_id == bid select s.book_id).ToList();
            return Json(bookid, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetMid(string mid)
        {
            var memberid = (from s in db.members where s.mssv == mid select s.name).ToList();
            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(issuebook issue)
        {
            if (Check.checkAmount(issue.book_id))
            {
                if (ModelState.IsValid)
                {
                    if (!Check.CanIssueBook(issue.member_id, issue.book_id))
                    {
                        return View();
                    }

                    db.issuebooks.Add(issue);
                    Check.removeBook(issue.book_id);
                    db.SaveChanges();
                    return View(issue);
                }
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index");
        }
    }
}
