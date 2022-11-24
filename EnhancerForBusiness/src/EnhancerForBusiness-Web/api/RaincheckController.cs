using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using EnhancerForBusiness_Web.Models;
using EnhancerForBusiness_Web.Utils;

namespace EnhancerForBusiness_Web.api
{
    [RoutePrefix("api/raincheck")]
    public class RaincheckController : ApiController
    {
        private readonly IRaincheckQuery _query;

        public RaincheckController(IRaincheckQuery query)
        {
            _query = query;
        }

        [HttpGet, Route]
        public Task<IEnumerable<Raincheck>> Get()
        {
            return _query.GetAllAsync();
        }

        [HttpGet, Route("{id}")]
        public Task<Raincheck> Get(int id)
        {
            return _query.FindAsync(id); 
        }

        [HttpPost, Route]
        public Task<int> Post([FromBody]Raincheck raincheck)
        {
            return _query.AddAsync(raincheck);
        }
    }
}
