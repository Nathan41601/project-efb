using System.Collections.Generic;
using System.Threading.Tasks;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.Utils
{
    public interface IRaincheckQuery
    {
        Task<int> AddAsync(Raincheck raincheck);
        Task<Raincheck> FindAsync(int id);
        Task<IEnumerable<Raincheck>> GetAllAsync();
    }
}
