namespace EnhancerForBusiness_Web.Security
{
    public interface ILoginProviderCredentials
    {
        string Key { get; }
        string Secret { get; }
        bool Use { get; }
    }
}