using System.Threading.Tasks;

namespace EnhancerForBusiness_Web.Utils
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri);
    }
}