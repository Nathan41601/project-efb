using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.ViewModels
{
    public class OrderDetailsViewModel
    {
        public OrderCostSummary OrderCostSummary { get; set; }
        public Order Order { get; set; }
    }
}