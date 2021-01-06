using LibraryManagerSystem.Helpers;
using LibraryManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagerSystem.Controllers
{
    public class ReturnBookController : Controller
    {
        nitlibraryEntities db = new nitlibraryEntities();
        // GET: ReturnBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMid(string mid)
        {
            //string bookReturnedText = ReturnBookStatus.Yes.GetDescription();
            //var bookReturnedText = "Đã trả";

            var memberid = db.issuebooks
                .Where(s => s.member_id == mid && s.status == null)
                .Select(s => new
                {
                    Membername = s.name_member,
                    BookName = s.book_name,
                    BookID = s.book_id
                }).ToArray();

            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(issuebook returns)
        {
            if (Check.checkReturn(returns.member_id, returns.book_id, returns.status))
            {
                Check.updateReturn(returns);
                return View(returns);
            }
            else
            {
                return View();
            }
        }
    }
}