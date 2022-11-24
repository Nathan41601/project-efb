using System.Collections.Generic;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public int CartCount { get; set; }
        public OrderCostSummary OrderCostSummary { get; set; }
    }
}
