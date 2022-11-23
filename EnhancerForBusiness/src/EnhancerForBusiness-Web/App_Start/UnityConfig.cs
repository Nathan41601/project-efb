using EnhancerForBusiness_Web.Models;
using EnhancerForBusiness_Web.ProductSearch;
using EnhancerForBusiness_Web.Utils;
using Microsoft.Practices.Unity;

namespace EnhancerForBusiness_Web
{
    public class UnityConfig
    {
        public static UnityContainer BuildContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IEnhancerForBusiness_WebContext, EnhancerForBusiness_WebContext>();
            container.RegisterType<IOrdersQuery, OrdersQuery>();
            container.RegisterType<IRaincheckQuery, RaincheckQuery>();
            container.RegisterType<ITelemetryProvider, TelemetryProvider>();
            container.RegisterType<IProductSearch, StringContainsProductSearch>();
            container.RegisterType<IShippingTaxCalculator, DefaultShippingTaxCalculator>();

			container.RegisterInstance<IHttpClient>(container.Resolve<HttpClientWrapper>());

            return container;
        }
    }
}