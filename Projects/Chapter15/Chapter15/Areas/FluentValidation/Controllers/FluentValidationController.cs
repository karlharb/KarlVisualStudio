using System.Web.Mvc;
using Chapter15.Areas.FluentValidation.Models;

namespace Chapter15.Areas.FluentValidation.Controllers
{
    public class FluentValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View(contact);
        }
    }
}
