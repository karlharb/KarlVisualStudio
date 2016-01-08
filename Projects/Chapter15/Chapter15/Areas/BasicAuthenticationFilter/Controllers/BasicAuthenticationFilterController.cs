using System.Web.Mvc;
using Chapter15.Areas.BasicAuthenticationFilter.Models;
using Chapter15.Areas.BasicAuthenticationFilter.Utility;

namespace Chapter15.Areas.BasicAuthenticationFilter.Controllers
{
    public class BasicAuthenticationFilterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [BasicAuthentication(Password = "secret")]
        [Authorize]
        public ActionResult Authenticated()
        {
            User model = new User { Name = User.Identity.Name };
            return View(model);
        }
    }
}