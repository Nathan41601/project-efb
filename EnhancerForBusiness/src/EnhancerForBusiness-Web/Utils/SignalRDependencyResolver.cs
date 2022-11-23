using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using Microsoft.Practices.Unity;

namespace EnhancerForBusiness_Web.Utils
{
    public class SignalRDependencyResolver : DefaultDependencyResolver
    {
        private readonly IUnityContainer _inner = MvcApplication.UnityContainer.CreateChildContainer();

        public override object GetService(Type serviceType)
        {
            try
            {
				if (serviceType.Name == "NewtownSoft.Serializer")
				{
					return _inner.Resolve(serviceType);
				}
				return base.GetService(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return base.GetService(serviceType);
            }
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            return _inner.ResolveAll(serviceType).Concat(base.GetServices(serviceType));
        }
    }
}