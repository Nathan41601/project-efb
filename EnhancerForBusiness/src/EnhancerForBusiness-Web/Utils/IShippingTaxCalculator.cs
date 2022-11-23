using System.Collections.Generic;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.Utils
{
	public interface IShippingTaxCalculator
	{
		OrderCostSummary CalculateCost(IEnumerable<ILineItem> items, string orderZip);
	}
}