using System.Threading;
using System.Web.Mvc;
using Chapter15.Areas.TimingFilter.Utility;

namespace Chapter15.Areas.TimingFilter.Controllers
{
    public class TimingFilterController : Controller
    {
        [ExecutionTiming]
        public ActionResult Index()
        {
            Thread.Sleep(100);
            return View();
        }
    }
}
