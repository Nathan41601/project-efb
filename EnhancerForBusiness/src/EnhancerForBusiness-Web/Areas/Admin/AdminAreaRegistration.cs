using System.Web.Mvc;

namespace EnhancerForBusiness_Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "EnhancerForBusiness_Web.Areas.Admin.Controllers" }
            );
        }

        public override string AreaName
        {
            get { return AdminConstants.Area; }
        }
    }
}