using System.Web.Mvc;

namespace EnhancerForBusiness_Web.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminConstants.Role)]
    public abstract class AdminController : Controller
    {
    }
}