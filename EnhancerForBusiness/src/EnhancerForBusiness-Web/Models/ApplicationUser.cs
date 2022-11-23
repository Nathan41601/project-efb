using Microsoft.AspNet.Identity.EntityFramework;

namespace EnhancerForBusiness_Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}