using System.Collections.Generic;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> NewProducts { get; set; }
        public List<Product> TopSellingProducts { get; set; }
        public List<CommunityPost> CommunityPosts { get; set; }
    }
}