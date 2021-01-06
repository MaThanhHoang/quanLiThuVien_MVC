using LibraryManagerSystem.Models;
using System.Linq;
using System.Web.Mvc;

namespace LibraryManagerSystem.Controllers
{
    public class LoginController : Controller
    {
        nitlibraryEntities db = new nitlibraryEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(admin adm)
        {
            // Check Model
            if (!ModelState.IsValid)
            {
                return View();

            }

            // Call DB
            var hasMember = db.admins.Where(x => x.useradmin == adm.useradmin  && x.password == adm.password).FirstOrDefault();
            if (hasMember == null)
            {
                adm.LoginErrorMessage = "Tài khoản hoặc mật khẩu không chính xác!";
                return View("Index", adm);
            }

            // Return view
            return RedirectToAction("Index", "Home");

            
        }
    }
}