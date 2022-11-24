using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnhancerForBusiness_Web.ProductSearch;
using System.Linq;
using System.Threading.Tasks;
using EnhancerForBusiness_Web.Tests.Mocks;

namespace EnhancerForBusiness_Web.Tests.ProductSearch
{
    [TestClass]
    public class ProductSearchTests
    {
        [TestMethod]
        public async Task ProductSearch_TestStringExistingProduct()
        {
            var prodSearch = new StringContainsProductSearch(new MockDataContext());
            var result = await prodSearch.Search("proDucT 1");
            var enumerable = result.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.IsTrue(enumerable.Any(p => p.Title == "Product 1"));
        }

        [TestMethod]
        public async Task ProductSearch_TestStringExistingProductPartial()
        {
            var prodSearch = new StringContainsProductSearch(new MockDataContext());
            var result = await prodSearch.Search("proD");
            Assert.AreEqual(6, result.Count());
        }

        [TestMethod]
        public async Task ProductSearch_TestStringNoHit()
        {
            var prodSearch = new StringContainsProductSearch(new MockDataContext());
            var result = await prodSearch.Search("nothing");
            Assert.AreEqual(0, result.Count());
        }
    }
}
