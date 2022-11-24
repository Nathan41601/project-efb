using System.Web.Configuration;
using EnhancerForBusiness_Web;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

//comment
namespace EnhancerForBusiness_Web
{
	// bellevue comment!!
	// second commit
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

#pragma warning disable CS0618 // Type or member is obsolete
            TelemetryConfiguration.Active.InstrumentationKey = WebConfigurationManager.AppSettings["Keys:ApplicationInsights:InstrumentationKey"];
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }
}
