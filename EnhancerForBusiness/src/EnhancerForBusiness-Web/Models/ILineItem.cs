namespace EnhancerForBusiness_Web.Models
{
	public interface ILineItem
	{
		int Count { get; }

		Product Product { get; }
	}
}
