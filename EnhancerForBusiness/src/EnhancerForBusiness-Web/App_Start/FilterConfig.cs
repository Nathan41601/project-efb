using System.Web.Mvc;
using EnhancerForBusiness_Web.Utils;

namespace EnhancerForBusiness_Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LayoutDataAttribute());
        }
    }
}