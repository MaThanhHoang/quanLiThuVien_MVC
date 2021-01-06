using LibraryManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagerSystem.Controllers
{
    public class SearchIssueController : Controller
    {
        // GET: SearchIssue
        private nitlibraryEntities db = new nitlibraryEntities();
        public ActionResult Index(string memberId, string submit)
        {

            if (string.IsNullOrEmpty(memberId) == null)
            {
                return View();
            }
            switch (submit)
            {
                case "Tìm kiếm":
                    return (Search(memberId));
                case "Lọc chưa trả":
                    return (Loc(memberId));
            }
            var issue = (from s in db.issuebooks select s).ToList();
            return View("Index", issue);
            //var search = db.issuebooks
            //                    .Where(x => x.member_id.Contains(memberId))
            //                    .ToList();

            //        return View(search);
                
                
            
        }
        [HttpGet]
        public ActionResult Loc(string memberId)
        {
            var search2 = db.issuebooks
                                .Where(x => x.member_id.Contains(memberId) && x.status == null)
                                .ToList();
                    return View(search2);
        }
        [HttpGet]
        public ActionResult Search(string memberId)
        {
            var search = db.issuebooks
                                .Where(x => x.member_id.Contains(memberId))
                                .ToList();
            return View(search);
        }
    }
}