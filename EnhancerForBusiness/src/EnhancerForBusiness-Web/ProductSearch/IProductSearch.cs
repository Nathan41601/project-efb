using System.Collections.Generic;
using System.Threading.Tasks;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.ProductSearch
{
    public interface IProductSearch
    {
        Task<IEnumerable<Product>> Search(string query);
    }
}
