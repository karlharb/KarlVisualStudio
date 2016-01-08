using System.Web.Mvc;

namespace Chapter15.Areas.CustomActionResult
{
    public class CustomActionResultAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "CustomActionResult"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "CustomActionResult_default",
                "CustomActionResult/{action}/{id}",
                new { controller = "CustomActionResult", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
