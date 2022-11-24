using Moq;
using System.Collections.Specialized;
using System.Net;
using System.Security.Principal;
using System.Web;

namespace EnhancerForBusiness_Web.Tests.Mocks
{
    public class MockHttpContext : HttpContextBase
    {
        private readonly Mock<HttpRequestBase> _mockRequest;
        private readonly IPrincipal _user;

        public MockHttpContext(string username = "bob", NameValueCollection queryString = null)
        {
            _user = new GenericPrincipal(new GenericIdentity(username), null /* roles */);

            _mockRequest = new Mock<HttpRequestBase>();
            _mockRequest.Setup(r => r.Headers).Returns(
                new WebHeaderCollection()
                {
                    { "X-Requested-With", "XMLHttpRequest" }
                }
            );
            _mockRequest.Setup(r => r.QueryString).Returns(queryString);
        }


        public override IPrincipal User
        {
            get
            {
                return _user;
            }
            set
            {
                base.User = value;
            }
        }

        public override HttpRequestBase Request
        {
            get
            {
                return _mockRequest.Object;
            }
        }
    }
}
