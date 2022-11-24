using System;
using System.Threading.Tasks;
using EnhancerForBusiness_Web.Models;
using EnhancerForBusiness_Web.ViewModels;

namespace EnhancerForBusiness_Web.Utils
{
    public interface IOrdersQuery
    {
        Task<Order> FindOrderAsync(int id);
        Task<OrdersModel> IndexHelperAsync(string username, DateTime? start, DateTime? end, string invalidOrderSearch, bool isAdminSearch);
    }
}
