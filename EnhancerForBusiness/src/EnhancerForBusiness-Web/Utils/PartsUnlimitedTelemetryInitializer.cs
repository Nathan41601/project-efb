using Microsoft.ApplicationInsights.Channel;

namespace EnhancerForBusiness_Web.Utils
{
    public class EnhancerForBusiness_WebTelemetryInitializer
    {
        string appVersion = GetApplicationVersion();

        private static string GetApplicationVersion()
        {
            return typeof(EnhancerForBusiness_WebTelemetryInitializer).Assembly.GetName().Version.ToString();
        }

        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Component.Version = appVersion;
        }
    }
}